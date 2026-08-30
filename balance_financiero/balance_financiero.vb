Imports System
Module balance_financiero
    Sub Main(args As String())
        Dim ids(9) As Integer
        Dim conceptos(9) As String
        Dim tipos(9) As String
        Dim categorias(9) As String
        Dim montos(9) As Double
        Dim fechas(9) As String
        Dim estados(9) As String
        Dim descripciones(9) As String
        Dim cantidad As Integer = 0
        Dim opcion As Integer
        '------------------------------------------'
        '--|menu_principal_de_balance_financiero|--'
        '------------------------------------------'
        Do
            Console.WriteLine("menu principal de balance financiero")
            Console.WriteLine("1) Registrar movimiento")
            Console.WriteLine("2) Editar movimiento")
            Console.WriteLine("3) Listar movimientos")
            Console.WriteLine("4) Buscar movimiento")
            Console.WriteLine("5) Eliminar movimiento")
            Console.WriteLine("6) Mostrar resumen")
            Console.WriteLine("7) Salir")
            Console.Write("Seleccione una opcion: ")
            opcion = Convert.ToInt32(Console.ReadLine())
            Select Case opcion
                '--------------------------'
                '--|registrar_movimiento|--'
                '--------------------------'
                Case 1
                    If cantidad >= ids.Length Then
                        Console.WriteLine("No hay espacio para registrar mas movimientos.")
                    Else
                        ids(cantidad) = cantidad + 1
                        Console.Write("Concepto: ")
                        conceptos(cantidad) = Console.ReadLine()
                        Console.Write("Tipo (Ingreso/Gasto/Activo/Pasivo): ")
                        tipos(cantidad) = Console.ReadLine()
                        Console.Write("Categoria: ")
                        categorias(cantidad) = Console.ReadLine()
                        Console.Write("Monto: ")
                        montos(cantidad) = Convert.ToDouble(Console.ReadLine())
                        Console.Write("Fecha: ")
                        fechas(cantidad) = Console.ReadLine()
                        Console.Write("Estado (Registrado/Pendiente/Cancelado): ")
                        estados(cantidad) = Console.ReadLine()
                        Console.Write("Descripcion: ")
                        descripciones(cantidad) = Console.ReadLine()
                        cantidad += 1
                        Console.WriteLine("Movimiento registrado correctamente.")
                    End If
                '-----------------------'
                '--|editar_movimiento|--'
                '-----------------------'
                Case 2
                    If cantidad = 0 Then
                        Console.WriteLine("No existen movimientos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Concepto: " & conceptos(i) & " | Tipo: " & tipos(i) & " | Categoria: " & categorias(i) & " | Monto: " & montos(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Descripcion: " & descripciones(i))
                        Next
                        Console.Write("Ingrese el ID del movimiento a editar: ")
                        Dim idEditar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEditar >= 1 And idEditar <= cantidad Then
                            Dim posicion As Integer = idEditar - 1
                            Console.Write("Nuevo concepto: ")
                            conceptos(posicion) = Console.ReadLine()
                            Console.Write("Nuevo tipo (Ingreso/Gasto/Activo/Pasivo): ")
                            tipos(posicion) = Console.ReadLine()
                            Console.Write("Nueva categoria: ")
                            categorias(posicion) = Console.ReadLine()
                            Console.Write("Nuevo monto: ")
                            montos(posicion) = Convert.ToDouble(Console.ReadLine())
                            Console.Write("Nueva fecha: ")
                            fechas(posicion) = Console.ReadLine()
                            Console.Write("Nuevo estado (Registrado/Pendiente/Cancelado): ")
                            estados(posicion) = Console.ReadLine()
                            Console.Write("Nueva descripcion: ")
                            descripciones(posicion) = Console.ReadLine()
                            Console.WriteLine("Movimiento actualizado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '------------------------'
                '--|listar_movimientos|--'
                '------------------------'
                Case 3
                    If cantidad = 0 Then
                        Console.WriteLine("No existen movimientos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Concepto: " & conceptos(i) & " | Tipo: " & tipos(i) & " | Categoria: " & categorias(i) & " | Monto: " & montos(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Descripcion: " & descripciones(i))
                        Next
                    End If
                '-----------------------'
                '--|buscar_movimiento|--'
                '-----------------------'
                Case 4
                    If cantidad = 0 Then
                        Console.WriteLine("No existen movimientos registrados.")
                    Else
                        Console.Write("Ingrese el ID del movimiento a buscar: ")
                        Dim idBuscar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idBuscar >= 1 And idBuscar <= cantidad Then
                            Dim posicion As Integer = idBuscar - 1
                            Console.WriteLine("ID: " & ids(posicion) & " | Concepto: " & conceptos(posicion) & " | Tipo: " & tipos(posicion) & " | Categoria: " & categorias(posicion) & " | Monto: " & montos(posicion) & " | Fecha: " & fechas(posicion) & " | Estado: " & estados(posicion) & " | Descripcion: " & descripciones(posicion))
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '-------------------------'
                '--|eliminar_movimiento|--'
                '-------------------------'
                Case 5
                    If cantidad = 0 Then
                        Console.WriteLine("No existen movimientos registrados.")
                    Else
                        For i As Integer = 0 To cantidad - 1
                            Console.WriteLine("ID: " & ids(i) & " | Concepto: " & conceptos(i) & " | Tipo: " & tipos(i) & " | Categoria: " & categorias(i) & " | Monto: " & montos(i) & " | Fecha: " & fechas(i) & " | Estado: " & estados(i) & " | Descripcion: " & descripciones(i))
                        Next
                        Console.Write("Ingrese el ID del movimiento a eliminar: ")
                        Dim idEliminar As Integer = Convert.ToInt32(Console.ReadLine())
                        If idEliminar >= 1 And idEliminar <= cantidad Then
                            Dim posicion As Integer = idEliminar - 1
                            For i As Integer = posicion To cantidad - 2
                                ids(i) = ids(i + 1)
                                conceptos(i) = conceptos(i + 1)
                                tipos(i) = tipos(i + 1)
                                categorias(i) = categorias(i + 1)
                                montos(i) = montos(i + 1)
                                fechas(i) = fechas(i + 1)
                                estados(i) = estados(i + 1)
                                descripciones(i) = descripciones(i + 1)
                            Next
                            cantidad -= 1
                            Console.WriteLine("Movimiento eliminado correctamente.")
                        Else
                            Console.WriteLine("ID no encontrada.")
                        End If
                    End If
                '---------------------'
                '--|mostrar_resumen|--'
                '---------------------'
                Case 6
                    If cantidad = 0 Then
                        Console.WriteLine("No existen movimientos registrados.")
                    Else
                        Dim totalIngresos As Double = 0
                        Dim totalGastos As Double = 0
                        Dim totalActivos As Double = 0
                        Dim totalPasivos As Double = 0
                        Dim ingresos As Integer = 0
                        Dim gastos As Integer = 0
                        Dim activos As Integer = 0
                        Dim pasivos As Integer = 0
                        Dim pendientes As Integer = 0
                        Dim cancelados As Integer = 0
                        Dim registrados As Integer = 0
                        Dim montoMayor As Double = montos(0)
                        Dim montoMenor As Double = montos(0)
                        Dim movimientoMayor As String = conceptos(0)
                        Dim movimientoMenor As String = conceptos(0)
                        Dim categoriaMasUtilizada As String = categorias(0)
                        Dim mayorCategoria As Integer = 0
                        For i As Integer = 0 To cantidad - 1
                            Select Case tipos(i).ToLower()
                                Case "ingreso"
                                    totalIngresos += montos(i)
                                    ingresos += 1
                                Case "gasto"
                                    totalGastos += montos(i)
                                    gastos += 1
                                Case "activo"
                                    totalActivos += montos(i)
                                    activos += 1
                                Case "pasivo"
                                    totalPasivos += montos(i)
                                    pasivos += 1
                            End Select
                            Select Case estados(i).ToLower()
                                Case "registrado"
                                    registrados += 1
                                Case "pendiente"
                                    pendientes += 1
                                Case "cancelado"
                                    cancelados += 1
                            End Select
                            If montos(i) > montoMayor Then
                                montoMayor = montos(i)
                                movimientoMayor = conceptos(i)
                            End If
                            If montos(i) < montoMenor Then
                                montoMenor = montos(i)
                                movimientoMenor = conceptos(i)
                            End If
                        Next
                        For i As Integer = 0 To cantidad - 1
                            Dim contadorCategoria As Integer = 0
                            For j As Integer = 0 To cantidad - 1
                                If categorias(i).ToLower() = categorias(j).ToLower() Then
                                    contadorCategoria += 1
                                End If
                            Next
                            If contadorCategoria > mayorCategoria Then
                                mayorCategoria = contadorCategoria
                                categoriaMasUtilizada = categorias(i)
                            End If
                        Next
                        Dim balance As Double = totalIngresos - totalGastos
                        Dim patrimonioNeto As Double = totalActivos - totalPasivos
                        Dim ingresoPromedio As Double = 0
                        Dim gastoPromedio As Double = 0
                        If ingresos > 0 Then
                            ingresoPromedio = totalIngresos / ingresos
                        End If
                        If gastos > 0 Then
                            gastoPromedio = totalGastos / gastos
                        End If
                        Console.WriteLine("Movimientos: " & cantidad & " | Ingresos: " & totalIngresos & " | Gastos: " & totalGastos & " | Activos: " & totalActivos & " | Pasivos: " & totalPasivos & " | Balance: " & balance & " | Patrimonio neto: " & patrimonioNeto & " | Ingreso promedio: " & ingresoPromedio & " | Gasto promedio: " & gastoPromedio & " | Mayor movimiento: " & movimientoMayor & " | Menor movimiento: " & movimientoMenor & " | Categoria mas utilizada: " & categoriaMasUtilizada & " | Registrados: " & registrados & " | Pendientes: " & pendientes & " | Cancelados: " & cancelados)
                    End If
                '------------------------------'
                '--|salir_del_menu_principal|--'
                '------------------------------'
                Case 7
                    Console.WriteLine("Gracias por utilizar Balance Financiero.")
                Case Else
                    Console.WriteLine("Opcion no valida.")
            End Select
        Loop While opcion <> 7
    End Sub
End Module