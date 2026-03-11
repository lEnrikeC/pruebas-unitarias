using Calculadora;
namespace Calculadora.Tests;

public class OperacionesMatematicasTests
{

    private readonly OperacionesMatematicas _operacionesMatematicas = new OperacionesMatematicas();

    [Fact]
    public void Sumar_DosPositivos_RetornaSuma()
    {
        // Arrange
        int a = 3, b = 6;   

        // Act
        int resultado = _operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(9, resultado);
    }

    [Fact]
    public void Sumar_DosNegativoMasPositivo_RetornaValorCorrecto()
    {
        // Arrange
        int a = -10, b = 10;

        // Act
        int resultado = _operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(0, resultado);
    }

    [Fact]
    public void Sumar_CeroMasCero_RetornaCero(){

        // Arrange
        int a = 0, b = 0;
        // Act
        int resultado = _operacionesMatematicas.Sumar(a, b);

        // Assert
        Assert.Equal(0, resultado);
    }
}
