<?php
/**
 * @author Fernando Calmet <fercalmet@gmail.com>
 * @link https://www.github.com/fernandocalmet
 */

interface ConexionBDInterface
{
    public function conectar();
}

interface GestorFiguraInterface
{
    public function calcular();
}

interface FiguraInterface
{
    public function area();
    public function perimetro();    
}

interface FiguraSolidaInterface
{
    public function volumen();
}

class CalcularAreaInvalidFigurasException extends Exception{}
class CalcularPerimetroInvalidFigurasException extends Exception{}
class CalcularVolumenInvalidFigurasException extends Exception{}

class ConexionMySQL implements ConexionBDInterface
{
    public function conectar()
    {
        return "Conexion con la base de datos";
    }
}

class guardarFiguras
{
    private $conexionBD;

    public function __construct(ConexionBDInterface $conexionBD)
    {
        $this->conexionBD = $conexionBD;
    }

    public function guardar($figuras)
    {     
        try
        {
            $conexion = $this->conexionBD->conectar();
            if($conexion && $figuras){return "Las figuras se han guardado en la base de datos.";}
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }
}

class Rectangulo implements FiguraInterface
{
    public $longitud;
    public $ancho;

    public function __construct($longitud, $ancho)
    {
        $this->longitud = $longitud;
        $this->ancho = $ancho;
    }

    public function area()
    {          
        return $this->longitud * $this->ancho;
    }  
        
    public function perimetro()
    {  
        return 2*($this->longitud + $this->ancho);       
    }    
}

class Circulo implements FiguraInterface
{
    public $radio;

    public function __construct($radio)
    {
        $this->radio = $radio;
    }

    public function area()
    {   
        return pi() * pow($this->radio, 2);  
    } 
    
    public function perimetro()
    {          
        return 2 * (pi() * $this->radio); 
    }

    public function volumen()
    {
        return ((4/3) * pi() * ($this->radio * $this->radio * $this->radio));
    }
}

class Cuadrado implements FiguraInterface, GestorFiguraInterface
{
    public $longitud;

    public function __construct($longitud)
    {
        $this->longitud = $longitud;
    }

    public function area()
    {    
        return pow($this->longitud, 2);
    }   

    public function perimetro()
    { 
        return $this->longitud * 4;   
    }

    public function volumen()
    {
        return ((4/3) * pi() * ($this->longitud * $this->longitud * $this->longitud));
    }

    public function calcular()
    {
        return $this->area();
    }
}

class Cuboide implements FiguraInterface, FiguraSolidaInterface
{
    public $altura;
    public $anchura;
    public $longitud;
    
    public function area()
    {
        return (2*(($this->longitud * $this->anchura)+($this->anchura * $this->altura)+($this->altura * $this->longitud)));
    }   

    public function perimetro()
    {  
        return (4 * ($this->longitud + $this->anchura + $this->altura)); 
    }    

    public function volumen()
    {
        return $this->longitud * $this->anchura * $this->altura;
    }

    public function calcular()
    {
        return $this->area() + $this->volumen();
    }
}

class CalcularArea
{
    protected $figuras;

    public function __construct($figuras = array())
    {
        $this->figuras = $figuras;
    }

    public function calcularArea()
    {  
        $i = 0;
        foreach($this->figuras as $figura)
        {
            if(is_a($figura, 'FiguraInterface'))
            {
                $area[$i] = $figura->area();
                $i++;
                continue;
            }
            throw new CalcularAreaInvalidFigurasException('Error al calcular el area');
        }
        return $area;
    }    
}

class CalcularAreaOutput
{
    protected $calculador;

    public function __construct(CalcularArea $calculador)
    {
        $this->calculador = $calculador;
    }

    public function HTML()
    {
        try
        {
            return implode('', array($this->calculador->calcularArea()));
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }

    public function JSON()
    {
        try
        {
            $data = array($this->calculador->calcularArea());
            return json_encode($data);
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }

    public function DUMP()
    {
        try
        {
            $data = $this->calculador->calcularArea();
            return var_dump($data);
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }
}

class CalcularPerimetro
{
    protected $figuras;

    public function __construct($figuras = array())
    {
        $this->figuras = $figuras;
    }

    public function calcularPerimetro()
    {  
        $i = 0;
        foreach($this->figuras as $figura)
        {
            if(is_a($figura, 'FiguraInterface'))
            {
                $perimetro[$i] = $figura->perimetro();
                $i++;
                continue;
            }
            throw new CalcularPerimetroInvalidFigurasException("Error al calcular el perimetro");
        }
        return $perimetro;
    }
}

class CalcularPerimetroOutput
{
    protected $figuras;

    public function __construct($figuras = array())
    {
        $this->figuras = $figuras;
    }

    public function HTML()
    {
        try
        {
            return implode('', array($this->figuras->calcularPerimetro()));
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }

    public function JSON()
    {
        try
        {
            $data = array($this->figuras->calcularPerimetro());
            return json_encode($data);
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }

    public function DUMP()
    {
        try
        {
            $data = $this->figuras->calcularPerimetro();
            return var_dump($data);
        }
        catch (Exception $ex)
        {
            return $ex;
        }
    }
}

class CalcularVolumen extends CalcularArea
{
    public function construct($figuras = array())
    {
        parent::construct($figuras);
    }

    public function calcularArea()
    {  
        $i = 0;
        foreach($this->figuras as $figura)
        {
            if(is_a($figura, 'FiguraInterface'))
            {
                $volumen[$i] = $figura->volumen();
                $i++;
                continue;
            }
            throw new CalcularVolumenInvalidFigurasException('Error al calcular el volumen del area');
        }
        return $volumen;
    } 
}

$figuras = array(
    new Rectangulo(32, 64),
    new Rectangulo(80, 30),
    new Rectangulo(12, 12),
    new Circulo(70),
    new Cuadrado(120)
);
$areas = new CalcularArea($figuras);
$volumenes = new CalcularArea($figuras);
$output1 = new CalcularAreaOutput($areas);
$output2 = new CalcularAreaOutput($volumenes);
$conexionBD = new ConexionMySQL();
$datos = new guardarFiguras($conexionBD);
$guardado1 = $datos->guardar($output1);
$guardado2 = $datos->guardar($output2);
echo $guardado1;
echo "<br>";
echo $guardado2;