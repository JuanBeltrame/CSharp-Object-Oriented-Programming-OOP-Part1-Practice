###
# Clases y métodos estáticos 
---
# I04 - La calculadora


# Consigna

Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta, multiplicación y división).

## Requisitos

Crear una clase llamada **Calculadora** que posea dos métodos estáticos:

- **Calcular (público)**:  
  - Recibirá tres parámetros: el primer operando, el segundo operando y la operación matemática.  
  - El método devolverá el resultado de la operación.

- **Validar (privado)**:  
  - Recibirá como parámetro el segundo operando.  
  - Este método se debe utilizar solo cuando la operación elegida sea la **DIVISIÓN**.  
  - Este método devolverá `true` si el operando es distinto de cero.

## Interacción con el usuario

- Se le debe pedir al usuario que **ingrese dos números** y la **operación** que desea realizar (ingresando el carácter `+`, `-`, `*` o `/`).
- El usuario decidirá **cuándo finalizar el programa**.
