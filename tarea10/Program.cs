// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
El Gobierno Nacional a través de su Ministerio de Salud requiere algunos datos sobre la campaña de vacunación para la mitigación del COVID, en tal sentido se necesitan los siguientes datos:

Listado de ciudadanos que no se han vacunado
Listado de ciudadanos que han recibido las dos vacunas
Listado de ciudadanos que solamente han recibido la vacuna de pfizer
Listado de ciudadanos que solamente han recibido la vacuna de Astrazeneca 
Para resolver el ejercicio considere lo siguiente:

Cree un conjunto ficticio de 500 ciudadanos
Cree un conjunto ficticio de 75 ciudadanos vacunados con pfizer
Cree un conjunto ficticio de 75 ciudadanos vacunados con astrazeneca

HashSet<string> ciudadanos = new HashSet<String>();
for i = 1 to 500
ciudadanos.Add("ciudadanos" + i)

HashSet<string> astrazeneca = new HashSet<String>();
for i = 1 to 75

HashSet<string> pfizer = new HashSet<String>();
for i = 1 to 75

Listado de ciudadanos que han recibido las dos vacunas
 
        HashSet<string> vacunadosPfizer = new HashSet<string>(ciudadanos.Take(75));
        HashSet<string> vacunadosAstrazeneca = new HashSet<string>(ciudadanos.Skip(75)
        
Listado de ciudadanos que no se han vacunado
HashSet<string> no vacunados = HashSet<string>(No vacunados diferencia (vacunados con Pfizer) diferencia (vacunados con Astrazeneca));


Listado de ciudadanos que solamente han recibido la vacuna de pfizer
HashSet<string> vacunados pfizer = HashSet<string>(vacunados pfizer diferencia(vacunados con astrazeneca) diferencia (No vacunados));


Listado de ciudadanos que solamente han recibido la vacuna de Astrazeneca
HashSet<string> vacunados astrazeneca= HashSet<string>(vacunados astrazeneca diferencia(vacunados con pfizer) diferencia (No vacunados));