<?php
/**
 * @author Fernando Calmet <fercalmet@gmail.com>
 * @link https://www.github.com/fernandocalmet
 */

interface FiguraInterface
{
    public function area();
    public function perimetro();
}

class CalcularAreaInvalidFigurasException extends Exception{}

class CalcularPerimetroInvalidFigurasException extends Exception{}

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
}

class Cuadrado implements FiguraInterface
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
    protected $figuras;

    public function __construct($figuras = array())
    {
        $this->figuras = $figuras;
    }

    public function HTML()
    {
        try
        {
            return implode('', $this->figuras->calcularArea());
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
            return json_encode($this->figuras->calcularArea());
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
            return var_dump($this->figuras->calcularArea());
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
            return implode('', $this->figuras->calcularPerimetro());
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
            return json_encode($this->figuras->calcularPerimetro());
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
            return var_dump($this->figuras->calcularPerimetro());
        }
        catch (Exception $ex)
        {
            return $ex;
        }
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
$output1 = new CalcularAreaOutput($areas);
echo $output1->HTML();
echo $output1->JSON();
echo $output1->DUMP();
$perimetros = new CalcularPerimetro($figuras);
$output2 = new CalcularPerimetroOutput($perimetros);
echo $output2->HTML();
echo $output2->JSON();
echo $output2->DUMP();