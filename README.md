# 🧮 Calculadora de Permutaciones y Coeficientes Multinomiales

Una potente herramienta de consola desarrollada en **C#** diseñada para resolver problemas de combinatoria y ordenación. El programa no solo calcula resultados, sino que educa al usuario mostrando el desglose matemático de cada operación.

---

## 🚀 Características Principales

Esta aplicación permite realizar seis tipos de operaciones fundamentales:

1.  **Cálculo de Factorial ($n!$):** Implementación recursiva con visualización del producto.
2.  **Permutación Simple ($P(n, r)$):** Cálculo de ordenaciones de $r$ elementos de un conjunto de $n$.
3.  **Comparativa Automática:** Función rápida para comparar magnitudes entre diferentes permutaciones ($P(10,3)$ vs $P(20,5)$).
4.  **Análisis Multinomial (Palabras):** Calcula cuántas palabras distintas se pueden formar con las letras de una palabra ingresada (ej: "BANANA"), identificando frecuencias automáticamente.
5.  **Análisis Multinomial (Cantidades):** Permite ingresar grupos de objetos directamente (ej: 4 rojos, 3 azules) para calcular sus formas de ordenación.
6.  **Banco de Ejemplos:** Demostraciones preconfiguradas para entender el uso de coeficientes multinomiales.

---

## Lógica Matemática

El programa utiliza las siguientes fórmulas de la teoría combinatoria:

### 1. Factorial
$$n! = n \times (n-1) \times \dots \times 1$$

### 2. Permutación ($n$ elementos tomados de $r$ en $r$)
$$P(n, r) = \frac{n!}{(n - r)!}$$

### 3. Coeficiente Multinomial
Para un conjunto de $n$ elementos donde existen grupos de elementos idénticos ($n_1, n_2, \dots, n_k$):
$$\frac{n!}{n_1! \times n_2! \times \dots \times n_k!}$$

---

## Detalles Técnicos

* **Lenguaje:** C# (.NET Core).
* **Gestión de Datos:** Uso de `Dictionary<char, int>` para el conteo de frecuencias de caracteres.
* **Procesamiento de Strings:** Implementación de `Linq` y `Split` para la limpieza y validación de entradas de usuario.
* **Robustez:** Validación de tipos de datos para evitar errores de ejecución por entradas nulas o caracteres no numéricos.

---

## Instalación y Ejecución

1.  Clona el repositorio:
    ```bash
    git clone [https://github.com/tu-usuario/calculadora-combinatoria.git](https://github.com/tu-usuario/calculadora-combinatoria.git)
    ```
2.  Accede a la carpeta y ejecuta:
    ```bash
    dotnet run
    ```

---

## Ejemplo de Salida (Caso Multinomial)

```text
Ingrese la palabra: BANANA

Palabra: BANANA
Letras y frecuencias:
  'B' aparece 1 vez
  'A' aparece 3 veces
  'N' aparece 2 veces

Procedimiento:
  Formula: n! / (n1! x n2! x ... x nk!)
  = 6! / (1! x 3! x 2!)
  = 720 / 12

Resultado: 60 palabras distintas pueden formarse.

## 📝 Ejemplo de Interacción

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
