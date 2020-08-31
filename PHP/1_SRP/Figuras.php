<?php
/**
 * @author Fernando Calmet <fercalmet@gmail.com>
 * @link https://www.github.com/fernandocalmet
 */

class Rectangulo
{
    public $longitud;
    public $ancho;

    public function __construct($longitud, $ancho)
    {
        $this->longitud = $longitud;
        $this->ancho = $ancho;
    }
}

class Circulo
{
    public $radio;

    public function __construct($radio)
    {
        $this->radio = $radio;
    }

}

class Cuadrado
{
    public $longitud;

    public function __construct($longitud)
    {
        $this->longitud = $longitud;
    }
}

class CalcularArea
{
    protected $figuras;

    public function __construct($figuras = array())
    {
        $this->figuras = $figuras;
    }

    public function area()
    {   
        for($i=0, $size=count($this->figuras); $i<$size; $i++)
        {         
            if(is_a($this->figuras[$i], 'Rectangulo'))
            {
                $area[$i] = $this->figuras[$i]->longitud * $this->figuras[$i]->ancho;
            }
            elseif(is_a($this->figuras[$i], 'Circulo'))
            {
                $area[$i] = pi() * pow($this->figuras[$i]->radio, 2);
            }
            elseif(is_a($this->figuras[$i], 'Cuadrado'))
            {
                $area[$i] = pow($this->figuras[$i]->longitud, 2);
            }
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
            return implode('', $this->figuras->area());
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
            return json_encode($this->figuras->area());
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
            return var_dump($this->figuras->area());
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

    public function perimetro()
    {  
        for($i=0, $size=count($this->figuras); $i<$size; $i++)
        {    
            if(is_a($this->figuras[$i], 'Rectangulo'))
            {
                $perimetro[$i] = 2*($this->figuras[$i]->longitud + $this->figuras[$i]->ancho);
            }
            elseif(is_a($this->figuras[$i], 'Circulo'))
            {
                $perimetro[$i] = 2 * (pi() * $this->figuras[$i]->radio);
            }
            elseif(is_a($this->figuras[$i], 'Cuadrado'))
            {
                $perimetro[$i] = $this->figuras[$i]->longitud * 4;
            }
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
            return implode('', $this->figuras->perimetro());
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
            return json_encode($this->figuras->perimetro());
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
            return var_dump($this->figuras->perimetro());
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