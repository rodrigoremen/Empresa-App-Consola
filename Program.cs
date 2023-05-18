using System;

    static void Main(string[] args) {
        double salarioMinimo;
        Console.Write("Ingrese el salario mínimo: ");
        while (!double.TryParse(Console.ReadLine(), out salarioMinimo)) {
            Console.WriteLine("El valor ingresado no es válido, por favor intente de nuevo.");
            Console.Write("Ingrese el salario mínimo: ");
        }

        Console.WriteLine("Ingrese su departamento: ");
        Console.WriteLine("A) Departamento A");
        Console.WriteLine("B) Departamento B");
        Console.WriteLine("C) Departamento C");
        char departamento;
        do {
            Console.Write("Departamento: ");
            departamento = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (departamento != 'A' && departamento != 'B' && departamento != 'C');

        int mesesAntiguedad;
        Console.Write("Ingrese su antigüedad en la empresa (en meses): ");
        while (!int.TryParse(Console.ReadLine(), out mesesAntiguedad) || mesesAntiguedad < 0) {
            Console.WriteLine("El valor ingresado no es válido, por favor intente de nuevo.");
            Console.Write("Ingrese su antigüedad en la empresa (en meses): ");
        }

        // Para calcular el bono de fin de año
        double bono = CalcularBono(salarioMinimo, departamento, mesesAntiguedad);
        Console.WriteLine("El bono de fin de año es: " + bono);

        // Para calcular el regalo por cada hijo
        Console.Write("Ingrese el número de hijos que tiene: ");
        int numHijos;
        while (!int.TryParse(Console.ReadLine(), out numHijos) || numHijos < 0) {
            Console.WriteLine("El valor ingresado no es válido, por favor intente de nuevo.");
            Console.Write("Ingrese el número de hijos que tiene: ");
        }
        double regalo = CalcularRegalo(numHijos);
        Console.WriteLine("El regalo por cada hijo es: " + regalo);

        // Se calcula el monto total
        double montoTotal = bono + regalo;
        Console.WriteLine("El monto total a recibir es: " + montoTotal);
    }

    static double CalcularBono(double salarioMinimo, char departamento, int mesesAntiguedad) {
        double bono = 0;
        switch (departamento) {
            case 'A':
                if (mesesAntiguedad < 24) {
                    bono = salarioMinimo * 5;
                } else {
                    bono = salarioMinimo * 8;
                }
                break;
            case 'B':
                if (mesesAntiguedad < 36) {
                    bono = salarioMinimo * 9;
                } else {
                    bono = salarioMinimo * 12;
                }
                break;
            case 'C':
                if (mesesAntiguedad < 60) {
                    bono = salarioMinimo * 14;
                } else {
                    bono = salarioMinimo * 17;
                }
                break;
        }
        return bono;
    }

    static double CalcularRegalo(int numHijos) {
        return numHijos * 150;
    }
}