using System.Net;
using Map_of_classes;


Rector rector = new Rector();
rector.FullName = "Gonzalo Almonte Henríquez";
Console.WriteLine($"Nombre del rector: {rector.FullName}.");


Student student = new Student(20241676, "Onasis Alexander Pereyra Jiménez", "203-23093901-9", "Residencial Pedro Alex, Calle #90, Sector Las Praderas");
Console.WriteLine($"""

    IdEstudiante: {student.StudentId}.
    Nombre completo: {student.FullName}.
    Cédula: {student.SocialId}.
    Dirección: {student.Address}.

    """);


ExStudent exStudent = new ExStudent(20251271, "Carlos Alexander Hughes Jiménez", "901-21093201-3", "Residencial Carlos Alex, Calle #110, Sector Las Mameyes");
Console.WriteLine($"""
    IdExEstudiante: {exStudent.StudentId}.
    Nombre completo: {exStudent.FullName}.
    Cédula: {exStudent.SocialId}.
    Dirección: {exStudent.Address}.

    """);


Administrator administrator = new Administrator(20251911, "Jose Pereyra Almonte", "201-28093201-1", "Administrador de recinto SDN", 35000, "Residencial Carlos Alex, Calle #110, Sector Las Mameyes");
Console.WriteLine($"""
    IdAdministrador: {administrator.EmployeeId}.
    Nombre completo: {administrator.FullName}.
    Cédula: {administrator.SocialId}.
    Posición: {administrator.Position}.
    Salario: {administrator.Salary}.
    Dirección: {administrator.Address}.

    """);


Professor professor = new Professor(20251911, "Diego Colón Almonte", "901-23567801-7", "Administrador de recinto SDN", 20000, "Residencial Carlos Alex, Calle #110, Sector Las Mameyes");
Console.WriteLine($"""
    IdProfesor: {professor.EmployeeId}.
    Nombre completo: {professor.FullName}.
    Cédula: {professor.SocialId}.
    Posición: {professor.Position}.
    Salario: {professor.Salary}.
    Dirección: {professor.Address}.

    """);









