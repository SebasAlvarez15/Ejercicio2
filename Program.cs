
Console.WriteLine("Bienvenidos a la Sala de Juegos" 
+"\nPor favor ingrese su nombre completo : ");
string nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su Edad : ");
uint edad = uint.Parse(Console.ReadLine());

if(edad < 4){
    Console.WriteLine("Nombre: "+ nombre + "\nEdad: "+edad +"\nPuedes entrar GRATIS");
    }
if (edad > 4 & edad < 18){
     int valor = 15000;
     int desc = 15000-750;
      Console.WriteLine("Nombre: "+ nombre + "\nEdad: "+edad 
      + "\nDebes pagar $15000, Por ser menor de edad " + "\nTienes un descuento del 5%: "+ valor*0.05
      +"\nTotal a pagar: " + desc );
    }

    if (edad > 18){
     int valor = 15000;
     int desc = 15000-450;
      Console.WriteLine("Nombre: "+ nombre + "\nEdad: "+edad 
      + "\nDebes pagar $15000, Por ser mayor de edad " + "\nTienes un descuento del 3%: "+ valor*0.03
      +"\nTotal a pagar: " + desc );
    }



//Console.WriteLine(nombre);