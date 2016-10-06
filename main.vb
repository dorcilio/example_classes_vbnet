Module VBModule
    Public Class Pessoa
        Public Cpf As String
        Public Nome As String
        Public Sobrenome As String
        Public Idade As Short
        Public Sexo As Char
        Public Camiseta As String

        Public Sub New()
        End Sub

        Public Sub New(ByVal _cpf As String, ByVal _nome As String, ByVal _sobrenome As String, ByVal _idade As Short, ByVal _sexo As Char, ByVal _camiseta As String)
            Me.Cpf = _cpf
            Me.Nome = _nome
            Me.Sobrenome = _sobrenome
            Me.Idade = _idade
            Me.Sexo = _sexo
            Me.Camiseta = _camiseta
        End Sub
    End Class
    
    Public Dim listaPessoas As New System.Collections.Generic.List(Of Pessoa)
    Public Dim Tot_Inscricoes As Double
    Public Dim Tot_Mensalidades As Double
 
    Public Sub Cadastra_Nadador(ByVal _pessoa As Pessoa)
        listaPessoas.Add(_pessoa)
        Tot_Inscricoes += 15.00
        Tot_Mensalidades += 100.00
    End Sub
    
    Public Sub Exibe_Nadadores()
        For Each p As Pessoa In listaPessoas
            Console.WriteLine("-----------------------------")
            Console.WriteLine("Nome Cpl: " + p.Nome + " " + p.Sobrenome)
            Console.WriteLine("CPF: " + p.Cpf)
            Console.WriteLine("Idade: " & p.Idade)
            Console.WriteLine("Sexo: " + p.Sexo)
            Console.WriteLine("Tam. Camiseta: " + p.Camiseta)
            Console.WriteLine("-----------------------------")
        Next
    End Sub
 
    Sub Main()
        Cadastra_Nadador(New Pessoa("04606668199", "Dorcilio", "Neto", 23, "M", "P"))
        Cadastra_Nadador(New Pessoa("05994594952", "Jefferson", "Zandona", 31, "M", "GG"))
        Cadastra_Nadador(New Pessoa("04985959598", "Raissa", "Gyus", 18, "F", "BLP"))
        Exibe_Nadadores()
        Console.WriteLine(Tot_Inscricoes)
        Console.WriteLine(Tot_Mensalidades)
    End Sub
  
End Module
