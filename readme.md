

[[Doc Calculadora.cs Desafio TDD 2]]
### Documentación y Explicación de la Clase `UnitTest1`

### Descripción
La clase `UnitTest1` proporciona una serie de pruebas unitarias para verificar el correcto funcionamiento de una clase `Calculadora`. Se utiliza el marco de pruebas `xUnit` para definir y ejecutar las pruebas.

### Categorización
- **Tipo:** Clase de Pruebas Unitarias
- **Propósito:** Verificar el funcionamiento de las operaciones aritméticas y el manejo del historial de operaciones en la clase `Calculadora`.
- **Contexto:** Módulo de pruebas para la validación de operaciones matemáticas y funcionalidades asociadas.

### Detalles del Código

```csharp
using Project1.Models;

namespace Project2;

public class UnitTest1
{
    // Construcción de la clase Calculadora para facilitar el uso en los scripts de test
    public Calculadora contruirClasse() 
    {
        string data = "22/05/2024";
        Calculadora calc = new Calculadora("22/05/2024");

        return calc;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(2, 4, 6)]
    public void somarTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse(); 

        int resultadoCalculado = cal.somar(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);
    }

    [Theory]
    [InlineData(2, 1, 1)]
    [InlineData(2, 2, 0)]
    public void subtrairTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse();

        int resultadoCalculado = cal.subtrair(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);      
    }

    [Theory]
    [InlineData(0, 2, 0)]
    [InlineData(2, 2, 4)]
    public void multiplicarTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse();

        int resultadoCalculado = cal.multiplicar(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);          
    }

    [Theory]
    [InlineData(2, 2, 1)]
    [InlineData(6, 2, 3)]
    public void dividirTest(int val1, int val2, int resultado)
    {
        Calculadora cal = contruirClasse();

        int resultadoCalculado = cal.dividir(val1, val2);

        Assert.Equal(resultado, resultadoCalculado);         
    }

    [Fact]
    public void dividirTestPorCero()
    {
        Calculadora calc = contruirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.dividir(3,0)  
        );   
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = contruirClasse();

        var calcLista = calc.historico();

        calc.somar(1, 2);
        calc.somar(1, 3);
        calc.somar(1, 4);

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, calcLista.Count);
    }
}
```

### Métodos de `UnitTest1`

#### Método `contruirClasse`
- **Descripción:** Construye una instancia de la clase `Calculadora` con una fecha específica.
- **Fragmento de código:**
  ```csharp
  public Calculadora contruirClasse() 
  {
      string data = "22/05/2024";
      Calculadora calc = new Calculadora("22/05/2024");

      return calc;
  }
  ```
- **Funcionamiento:** Inicializa una nueva instancia de `Calculadora` con la fecha "22/05/2024".

#### Prueba `somarTest`
- **Descripción:** Verifica la operación de suma de la calculadora.
- **Fragmento de código:**
  ```csharp
  [Theory]
  [InlineData(1, 2, 3)]
  [InlineData(2, 4, 6)]
  public void somarTest(int val1, int val2, int resultado)
  {
      Calculadora cal = contruirClasse(); 

      int resultadoCalculado = cal.somar(val1, val2);

      Assert.Equal(resultado, resultadoCalculado);
  }
  ```
- **Funcionamiento:** Utiliza `Theory` para probar múltiples escenarios de suma, verificando que el resultado calculado sea igual al esperado.

#### Prueba `subtrairTest`
- **Descripción:** Verifica la operación de resta de la calculadora.
- **Fragmento de código:**
  ```csharp
  [Theory]
  [InlineData(2, 1, 1)]
  [InlineData(2, 2, 0)]
  public void subtrairTest(int val1, int val2, int resultado)
  {
      Calculadora cal = contruirClasse();

      int resultadoCalculado = cal.subtrair(val1, val2);

      Assert.Equal(resultado, resultadoCalculado);      
  }
  ```
- **Funcionamiento:** Utiliza `Theory` para probar múltiples escenarios de resta, verificando que el resultado calculado sea igual al esperado.

#### Prueba `multiplicarTest`
- **Descripción:** Verifica la operación de multiplicación de la calculadora.
- **Fragmento de código:**
  ```csharp
  [Theory]
  [InlineData(0, 2, 0)]
  [InlineData(2, 2, 4)]
  public void multiplicarTest(int val1, int val2, int resultado)
  {
      Calculadora cal = contruirClasse();

      int resultadoCalculado = cal.multiplicar(val1, val2);

      Assert.Equal(resultado, resultadoCalculado);          
  }
  ```
- **Funcionamiento:** Utiliza `Theory` para probar múltiples escenarios de multiplicación, verificando que el resultado calculado sea igual al esperado.

#### Prueba `dividirTest`
- **Descripción:** Verifica la operación de división de la calculadora.
- **Fragmento de código:**
  ```csharp
  [Theory]
  [InlineData(2, 2, 1)]
  [InlineData(6, 2, 3)]
  public void dividirTest(int val1, int val2, int resultado)
  {
      Calculadora cal = contruirClasse();

      int resultadoCalculado = cal.dividir(val1, val2);

      Assert.Equal(resultado, resultadoCalculado);         
  }
  ```
- **Funcionamiento:** Utiliza `Theory` para probar múltiples escenarios de división, verificando que el resultado calculado sea igual al esperado.

#### Prueba `dividirTestPorCero`
- **Descripción:** Verifica que la división por cero lanza una excepción `DivideByZeroException`.
- **Fragmento de código:**
  ```csharp
  [Fact]
  public void dividirTestPorCero()
  {
      Calculadora calc = contruirClasse();

      Assert.Throws<DivideByZeroException>(
          () => calc.dividir(3,0)  
      );   
  }
  ```
- **Funcionamiento:** Utiliza `Fact` para probar que la división por cero lanza la excepción esperada.

#### Prueba `TestarHistorico`
- **Descripción:** Verifica que el historial de operaciones de la calculadora se mantenga correctamente.
- **Fragmento de código:**
  ```csharp
  [Fact]
  public void TestarHistorico()
  {
      Calculadora calc = contruirClasse();

      var calcLista = calc.historico();

      calc.somar(1, 2);
      calc.somar(1, 3);
      calc.somar(1, 4);

      Assert.NotEmpty(calc.historico());
      Assert.Equal(3, calcLista.Count);
  }
  ```

- **Funcionamiento:** Utiliza `Fact` para probar que las operaciones se agregan al historial correctamente y que el historial no está vacío después de realizar operaciones.

### Resumen
La clase `UnitTest1` encapsula varias pruebas unitarias para la clase `Calculadora`, verificando operaciones aritméticas básicas (suma, resta, multiplicación, división) y funcionalidades adicionales como el manejo de excepciones y el mantenimiento de un historial de operaciones. Estas pruebas aseguran que la `Calculadora` funcione correctamente en diferentes escenarios y que se manejen adecuadamente casos especiales como la división por cero.

[[Doc UnitTest1.cs Desafio TDD 2]]

### Documentación y Explicación de la Clase `Calculadora`

### Descripción
La clase `Calculadora` proporciona funcionalidades básicas de cálculo aritmético (suma, resta, multiplicación y división) y mantiene un historial de todas las operaciones realizadas junto con la fecha en que se realizaron.

### Categorización
- **Tipo:** Clase de Servicio
- **Propósito:** Realizar operaciones aritméticas y mantener un registro de dichas operaciones con la fecha.
- **Contexto:** Utilizada para realizar cálculos y guardar el historial de operaciones en aplicaciones que requieran estas funcionalidades.

### Detalles del Código

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Calculadora
    {
        private List<string> Listahistorico;
        private string data;

        public Calculadora(string ddata) 
        {
            Listahistorico = new List<string>();
            data = ddata; // Corrección: Asignar el valor del parámetro a la variable de instancia
        }

        public int somar(int val1, int val2)
        {      
            int res = val1 + val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public int subtrair(int val1, int val2)
        {
            int res = val1 - val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public int multiplicar(int val1, int val2)
        {   
            int res = val1 * val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public int dividir(int val1, int val2)
        {  
            int res = val1 / val2;
            Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
            return res;
        }

        public List<string> historico()
        {
            return Listahistorico;
        }
    }
}
```

### Métodos de `Calculadora`

#### Constructor `Calculadora`
- **Descripción:** Inicializa una nueva instancia de la clase `Calculadora` con una lista vacía para el historial y asigna una fecha.
- **Fragmento de código:**
  ```csharp
  public Calculadora(string ddata) 
  {
      Listahistorico = new List<string>();
      data = ddata; // Corrección: Asignar el valor del parámetro a la variable de instancia
  }
  ```
- **Funcionamiento:** Crea una lista vacía para el historial de operaciones y asigna la fecha proporcionada a la variable `data`.

#### Método `somar`
- **Descripción:** Realiza la suma de dos valores y guarda el resultado en el historial.
- **Fragmento de código:**
  ```csharp
  public int somar(int val1, int val2)
  {      
      int res = val1 + val2;
      Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
      return res;
  }
  ```
- **Funcionamiento:** Suma `val1` y `val2`, guarda el resultado y la fecha en el historial, y devuelve el resultado.

#### Método `subtrair`
- **Descripción:** Realiza la resta de dos valores y guarda el resultado en el historial.
- **Fragmento de código:**
  ```csharp
  public int subtrair(int val1, int val2)
  {
      int res = val1 - val2;
      Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
      return res;
  }
  ```
- **Funcionamiento:** Resta `val2` de `val1`, guarda el resultado y la fecha en el historial, y devuelve el resultado.

#### Método `multiplicar`
- **Descripción:** Realiza la multiplicación de dos valores y guarda el resultado en el historial.
- **Fragmento de código:**
  ```csharp
  public int multiplicar(int val1, int val2)
  {   
      int res = val1 * val2;
      Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
      return res;
  }
  ```
- **Funcionamiento:** Multiplica `val1` y `val2`, guarda el resultado y la fecha en el historial, y devuelve el resultado.

#### Método `dividir`
- **Descripción:** Realiza la división de dos valores y guarda el resultado en el historial.
- **Fragmento de código:**
  ```csharp
  public int dividir(int val1, int val2)
  {  
      int res = val1 / val2;
      Listahistorico.Insert(0, $"Res: {res} - Data: {data}");
      return res;
  }
  ```
- **Funcionamiento:** Divide `val1` entre `val2`, guarda el resultado y la fecha en el historial, y devuelve el resultado.

#### Método `historico`
- **Descripción:** Devuelve el historial de operaciones.
- **Fragmento de código:**
  ```csharp
  public List<string> historico()
  {
      return Listahistorico;
  }
  ```
- **Funcionamiento:** Retorna la lista `Listahistorico` que contiene el historial de todas las operaciones realizadas.

### Resumen
La clase `Calculadora` proporciona métodos para realizar operaciones aritméticas básicas y mantener un registro detallado de cada operación realizada, incluyendo la fecha. Esta funcionalidad es útil para aplicaciones que requieren un seguimiento de las operaciones y sus resultados, lo cual es común en sistemas financieros o educativos donde se necesita transparencia y seguimiento de cálculos realizados.

