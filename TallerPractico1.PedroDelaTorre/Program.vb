Imports System
Imports System.IO
Imports System.Reflection.Emit
Imports System.Text
Module Program
    Sub operaciones_matematicas()
        Dim tamano_array As Integer
        While True
            Console.WriteLine("Operaciones Matematicas")
            Console.WriteLine("Ingrese la cantidad de numeros (2-99)")
            Dim entrada_array As String = Console.ReadLine()
            If Integer.TryParse(entrada_array, tamano_array) AndAlso tamano_array >= 2 AndAlso tamano_array <= 99 Then
                Console.Clear()
                Exit While
            Else
                Console.Clear()
                Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End If
        End While
        Dim operandos(tamano_array) As Double
        For contador1 As Integer = 0 To (tamano_array - 1) Step 1
            While True
                Console.WriteLine("Operaciones Matematicas")
                Console.WriteLine($"Ingrese el numero N° {contador1 + 1}")
                Dim entrada_numero As String = Console.ReadLine()
                If Double.TryParse(entrada_numero, operandos(contador1)) AndAlso entrada_numero >= -999999999999 AndAlso entrada_numero <= 999999999999 Then
                    Console.Clear()
                    Exit While
                Else
                    Console.Clear()
                    Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
                End If
            End While
        Next
        Dim contador2 As Integer = 1
        Dim contador3 As Integer = 1
        Dim contador5 As Integer = 1
        Dim suma_total As Double = operandos(0)
        Dim resta_total As Double = operandos(0)
        Dim multiplicacion_total As Double = operandos(0)
        Dim division_total As Double = operandos(0)
        Dim exponente_total As Double = operandos(0)
        Dim mod_total As Double = operandos(0)
        Dim flag_division As Boolean = False
        Dim flag_mod As Boolean = False
        Do While contador2 <= tamano_array - 1
            suma_total = suma_total + operandos(contador2)
            resta_total = resta_total - operandos(contador2)
            multiplicacion_total = multiplicacion_total * operandos(contador2)
            exponente_total = exponente_total ^ operandos(contador2)
            contador2 = contador2 + 1
        Loop
        Do While contador3 <= tamano_array - 1
            If operandos(contador3) <> 0 Then
                division_total = division_total / operandos(contador3)
                contador3 = contador3 + 1
            Else
                flag_division = True
                Exit Do
            End If
        Loop
        Do While contador5 <= tamano_array - 1
            If operandos(contador5) <> 0 Then
                mod_total = mod_total Mod operandos(contador5)
                contador5 = contador5 + 1
            Else
                flag_mod = True
                Exit Do
            End If
        Loop
        Console.WriteLine("Operaciones Matematicas")
        For contador4 As Integer = 0 To (tamano_array - 1)
            Console.WriteLine($"{contador4 + 1}. {operandos(contador4).ToString("F2")}")
        Next
        Console.WriteLine("Suma")
        If suma_total > 999999999999999999 Then
            Console.WriteLine("Error! Resultado fuera de los limites del programa")
        Else
            Console.WriteLine($"{suma_total.ToString("F2")}")
        End If
        Console.WriteLine("Resta")
        If resta_total > 999999999999999999 Then
            Console.WriteLine("Error! Resultado fuera de los limites del programa")
        Else
            Console.WriteLine($"{resta_total.ToString("F2")}")
        End If
        Console.WriteLine("Producto")
        If multiplicacion_total > 999999999999999999 Then
            Console.WriteLine("Error! Resultado fuera de los limites del programa")
        Else
            Console.WriteLine($"{multiplicacion_total.ToString("F2")}")
        End If
        Console.WriteLine("Division")
        If flag_division = True Then
            Console.WriteLine("Operacion Invalida! Uno de los divisores es 0")
        Else
            If division_total > 999999999999999999 Then
                Console.WriteLine("Error! Resultado fuera de los limites del programa")
            Else
                Console.WriteLine($"{division_total.ToString("F2")}")
            End If
        End If
        Console.WriteLine("Exponente")
        If exponente_total > 999999999999999999 Then
            Console.WriteLine("Error! Resultado fuera de los limites del programa")
        Else
            Console.WriteLine($"{exponente_total.ToString("F2")}")
        End If
        Console.WriteLine("Residuo")
        If flag_mod = True Then
            Console.WriteLine("Operacion Invalida! Uno de los divisores es 0")
        Else
            If mod_total > 999999999999999999 Then
                Console.WriteLine("Error! Resultado fuera de los limites del programa")
            Else
                Console.WriteLine($"{mod_total.ToString("F2")}")
            End If
        End If
        Console.WriteLine("Presione cualquier tecla para continuar")
        Console.ReadKey()
        Console.Clear()
    End Sub
    Sub convertidor_moneda()
        Dim euro As Single = 1.1
        Dim dolar As Single = 1
        Dim yen As Single = 0.0075
        Dim yuan As Single = 0.14
        Dim libra As Single = 1.24
        Dim moneda_entrada As Single, moneda_salida As Single, cantidad_entrada As Single, cantidad_salida As Single
        Dim opcion_menu_moneda As String, simbolo_entrada As String, simbolo_salida As String
        Dim euro_simbolo As String = "Euro Europeo (€)"
        Dim dolar_simbolo As String = "Dolar americano ($)"
        Dim yen_simbolo As String = "Yen Japones (¥)"
        Dim yuan_simbolo As String = "Yuan Chino (¥)"
        Dim libra_simbolo As String = "Libra britanica (£)"
        Console.OutputEncoding = System.Text.Encoding.UTF8
        Do While True
            Console.WriteLine("Convertidor de Moneda")
            Console.WriteLine("Elija la moneda de entrada")
            Console.WriteLine("1. Euro Europeo (€)")
            Console.WriteLine("2. Dolar americano ($)")
            Console.WriteLine("3. Yen Japones (¥)")
            Console.WriteLine("4. Yuan Chino (¥)")
            Console.WriteLine("5. Libra britanica (£)")
            Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
            opcion_menu_moneda = Console.ReadLine()
            Select Case opcion_menu_moneda
                Case 1
                    moneda_entrada = euro
                    simbolo_entrada = euro_simbolo
                    Console.Clear()
                    Exit Do
                Case 2
                    moneda_entrada = dolar
                    simbolo_entrada = dolar_simbolo
                    Console.Clear()
                    Exit Do
                Case 3
                    moneda_entrada = yen
                    simbolo_entrada = yen_simbolo
                    Console.Clear()
                    Exit Do
                Case 4
                    moneda_entrada = yuan
                    simbolo_entrada = yuan_simbolo
                    Console.Clear()
                    Exit Do
                Case 5
                    moneda_entrada = libra
                    simbolo_entrada = libra_simbolo
                    Console.Clear()
                    Exit Do
                Case Else
                    Console.Clear()
                    Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End Select
        Loop
        Do While True
            Console.WriteLine("Convertidor de Moneda")
            Console.WriteLine("Elija la moneda de salida")
            Console.WriteLine("1. Euro Europeo (€)")
            Console.WriteLine("2. Dolar americano ($)")
            Console.WriteLine("3. Yen Japones (¥)")
            Console.WriteLine("4. Yuan Chino (¥)")
            Console.WriteLine("5. Libra britanica (£)")
            Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
            opcion_menu_moneda = Console.ReadLine()
            Select Case opcion_menu_moneda
                Case 1
                    moneda_salida = euro
                    simbolo_salida = euro_simbolo
                    Console.Clear()
                    Exit Do
                Case 2
                    moneda_salida = dolar
                    simbolo_salida = dolar_simbolo
                    Console.Clear()
                    Exit Do
                Case 3
                    moneda_salida = yen
                    simbolo_salida = yen_simbolo
                    Console.Clear()
                    Exit Do
                Case 4
                    moneda_salida = yuan
                    simbolo_salida = yuan_simbolo
                    Console.Clear()
                    Exit Do
                Case 5
                    moneda_salida = libra
                    simbolo_salida = libra_simbolo
                    Console.Clear()
                    Exit Do
                Case Else
                    Console.Clear()
                    Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End Select
        Loop
        While True
            Console.WriteLine("Convertidor de Moneda")
            Console.WriteLine("Ingrese la cantidad de entrada")
            Dim entrada_moneda As String = Console.ReadLine()
            If Single.TryParse(entrada_moneda, cantidad_entrada) AndAlso cantidad_entrada >= 0 AndAlso cantidad_entrada <= 999999999999 Then
                Console.Clear()
                Exit While
            Else
                Console.Clear()
                Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End If
        End While
        cantidad_salida = cantidad_entrada * (moneda_entrada / moneda_salida)
        Console.WriteLine("Convertidor de Moneda")
        If cantidad_salida < 999999999999999999 Then
            Console.WriteLine($"{cantidad_entrada.ToString("F2")} {simbolo_entrada}")
            Console.WriteLine("=")
            Console.WriteLine($"{cantidad_salida.ToString("F2")} {simbolo_salida}")
        Else
            Console.WriteLine("Error! Resultado fuera de los limites del programa")
        End If
        Console.WriteLine("Presione cualquier tecla para continuar")
        Console.ReadKey()
        Console.Clear()
    End Sub
    Sub reloj_militar()
        Dim horas, minutos, segundos As Integer
        While True
            Console.WriteLine("Reloj Militar")
            Console.WriteLine("Ingrese la cantidad de horas (0-23)")
            Dim entrada_horas As String = Console.ReadLine()
            If Integer.TryParse(entrada_horas, horas) AndAlso horas >= 0 AndAlso horas <= 23 Then
                Console.Clear()
                Exit While
            Else
                Console.Clear()
                Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End If
        End While
        While True
            Console.WriteLine("Reloj Militar")
            Console.WriteLine("Ingrese la cantidad de minutos (0-59)")
            Dim entrada_minutos As String = Console.ReadLine()
            If Integer.TryParse(entrada_minutos, minutos) AndAlso minutos >= 0 AndAlso minutos <= 59 Then
                Console.Clear()
                Exit While
            Else
                Console.Clear()
                Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End If
        End While
        While True
            Console.WriteLine("Reloj Militar")
            Console.WriteLine("Ingrese la cantidad de segundos (0-59)")
            Dim entrada_segundos As String = Console.ReadLine()
            If Integer.TryParse(entrada_segundos, segundos) AndAlso segundos >= 0 AndAlso segundos <= 59 Then
                Console.Clear()
                Exit While
            Else
                Console.Clear()
                Console.WriteLine("Entrada Invalida! Por favor ingrese una opcion valida")
            End If
        End While
        Console.WriteLine("Reloj Militar")
        Console.WriteLine("Entrada")
        Console.WriteLine($"{horas.ToString("D2")}:{minutos.ToString("D2")}:{segundos.ToString("D2")}")
        Console.WriteLine("Salida +1 segundo")
        segundos = segundos + 1
        If segundos = 60 Then
            segundos = 0
            minutos = minutos + 1
        End If
        If minutos = 60 Then
            minutos = 0
            horas = horas + 1
        End If
        If horas = 24 Then
            horas = 0
        End If
        Console.WriteLine($"{horas.ToString("D2")}:{minutos.ToString("D2")}:{segundos.ToString("D2")}")
        Console.WriteLine("Presione cualquier tecla para continuar")
        Console.ReadKey()
        Console.Clear()
    End Sub
    Sub Main(args As String())
        Dim opcion_menu_principal As String
        Do While True
            Console.WriteLine("BIENVENIDO")
            Console.WriteLine("¿Que desea hacer?")
            Console.WriteLine("1. Operaciones Matematicas")
            Console.WriteLine("2. Convertidor de Moneda")
            Console.WriteLine("3. Reloj Militar")
            Console.WriteLine("4. Salir")
            Console.WriteLine("favor ingresar el numero correspondiente a la opcion deseada")
            opcion_menu_principal = Console.ReadLine()
            Console.Clear()
            Select Case opcion_menu_principal
                Case 1
                    operaciones_matematicas()
                Case 2
                    convertidor_moneda()
                Case 3
                    reloj_militar()
                Case 4
                    Environment.Exit(0)
                Case Else
                    Console.Clear()
                    Console.WriteLine("Seleccion Invalida! Por favor ingrese una opcion valida")
            End Select
        Loop
    End Sub
End Module