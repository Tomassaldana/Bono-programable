#Calculadora de Permutaciones en C#

Una aplicación de consola robusta y educativa desarrollada en **C#** para el cálculo de factoriales y permutaciones. El programa destaca por desglosar el procedimiento matemático paso a paso, facilitando la comprensión del usuario.

---

##Características

* **Cálculo de Factorial ($n!$):** Implementado mediante lógica recursiva eficiente.
* **Cálculo de Permutaciones ($P(n, r)$):** Aplicación de la fórmula de ordenación sin repetición.
* **Validación Estricta:** El sistema asegura que las entradas sean números enteros no negativos y que $r \le n$.
* **Modo Comparativo:** Opción preconfigurada para comparar resultados complejos como $P(10, 3)$ y $P(20, 5)$.
* **Visualización de Procedimientos:** No solo entrega el resultado, muestra la cadena de multiplicación (ej. $4! = 4 \times 3 \times 2 \times 1$).

---

##Fundamentos Matemáticos

El núcleo lógico del programa utiliza las siguientes definiciones:

1.  **Factorial:**
    $$n! = n \times (n-1) \times (n-2) \times \dots \times 1$$
2.  **Permutación:**
    $$P(n, r) = \frac{n!}{(n - r)!}$$

---

## 🛠️ Arquitectura del Código

El proyecto está modularizado en métodos estáticos para garantizar legibilidad y reutilización:

| Método | Responsabilidad |
| :--- | :--- |
| `Factorial` | Calcula el producto acumulado de forma recursiva (usa tipo `long` para evitar desbordamientos). |
| `Permutacion` | Coordina la división de factoriales para obtener el resultado combinatorio. |
| `ValidarEntero` | Filtra las entradas del usuario para evitar errores lógicos con números negativos. |
| `MostrarProcedimientoFactorial` | Construye una cadena de texto (String) con el desglose de la operación. |
| `MostrarPermutacionDetallada` | Encapsula la lógica de impresión estética en consola para el usuario. |

---

## 💻 Instalación y Uso

### Requisitos
* [.NET SDK](https://dotnet.microsoft.com/download) (Versión 6.0 o superior).

### Pasos para ejecutar
1.  Clona este repositorio o copia el archivo `Program.cs`.
2.  Abre una terminal en la carpeta del proyecto.
3.  Ejecuta el comando:
    ```bash
    dotnet run
    ```

---

## Ejemplo de Interacción

```text
=== Calculadora de Permutaciones ===
Oprima 1 para calcular n!
Oprima 2 para calcular P(n, r)
Oprima 3 para comparar P(10,3) y P(20,5)

> 2
Ha escogido calcular P(n, r).
Ingrese n: 5
Ingrese r: 3

Procedimiento:
  P(n, r) = n! / (n - r)!
  P(5, 3) = 5! / (5 - 3)!
  P(5, 3) = 120 / 2
Resultado: P(5, 3) = 60
