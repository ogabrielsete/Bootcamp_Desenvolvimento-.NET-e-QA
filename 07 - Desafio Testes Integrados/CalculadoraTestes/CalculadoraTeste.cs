using Calculadora.Services;

namespace calculadoratestes;

public class CalculadoraTeste
{
    private CalculadoraImp _calc;
    public CalculadoraTeste()
    {
        _calc = new CalculadoraImp();
    }
    [Fact]
    public void DeveSomar20Com30ERetornar50()
    {
        // Arrange
        int n1 = 20;
        int n2 = 30;

        // Act
        int resultado = _calc.Somar(n1, n2);

        // Assert
        Assert.Equal(50, resultado);
    }

    [Fact]
    public void DeveVerificarSe4EParERetornarVerdadeiro()
    {
        // Arrange
        int numero = 4;
        // Act 
        bool resultado = _calc.EhPar(numero);
        // Assert
        Assert.True(resultado);
    }

    [Theory]
    [InlineData(new int[] { 2, 4 })]
    [InlineData(new int[] { 6, 8, 10 })]
    public void VerificarSeOsNumerosSaoParesERetornarVerdadeiro(int[] numero)
    {

        // Act        // Assert
            Assert.All(numero, x => Assert.True(_calc.EhPar(x)));
        
    }
}