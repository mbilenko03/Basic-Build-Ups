If Statements:
if (condition)
{}
else if (condition)
{}
else
{}

Switch Statements:
switch (variable)
{
case variablevalue:
 code
break;
default:
code
break;
}




For Loop:
For ([initializers] int i = 0; [condition]  i < 10; [iterator] i++)
{}

While Loop:
while (variable = condition)
{}

Do While Loop:
do
{}
while (variable = condition)










Method Layout:
Method Signature
{
Method Body
}

Method Signature:
Access Modifier | Return Type | Method Name (Parameter List)
Access Modifier:
•	private - most restrictive and allows access to the method only from within the containing class or struct
•	public - least restrictive, allowing access from any code in the application
•	protected - allows for access from within the containing class or from within derived classes
•	internal - accessible from files within the same assembly
•	static - indicates the method is a static member of the class rather than a member of an instance of a specific object

Return Type: Data Type
Parameter List:
You can make parameters specific… (string Name = null, int serviceID = 1) or (true, serviceID : 1)
 

Calling Methods:
Method Name (Inputting Variables);
Access Modifier | Return Type | Method Name (Customize Variables)

Returning Data:
Access Modifier | Return Type | Method Name (Parameter List)
Parameter List:
	Ref – input variable, output will change the variable
	Out – no input, just output a variable
You can set a variable to the method.

Overloading Methods:
void StopService()
{
   // This method accepts no arguments
}
void StopService(string serviceName)
{
   // This method overload accepts a single string argument
}
void StopService(int serviceId)
{
   // This method overload accepts a single integer argument
}


Exceptions:
try
{
code from which you are trying to catch an exception
}
catch (exception variable)
{
code to do if the exception is present
}
finally
{
  	code you always want to run no matter what
}

Throw; - lets the method who called the current method deal with the exception do
in the catch block 
or
throw new exception(); 





Arrays:
Declaring Size:
datatype[] arrVariable = new datatype[];

Accessing Elements:
datatype[] arrVariable = {1, 2, 3, 4, 5, 6 };
datatype variable = arrVariable[0]  

Iterating Array:
for (int i = 0; i < oldNumbers.Length; i++)
{
    int number = oldNumbers[i];
}

Multidimensional Arrays:
datatype[ , ] arrVariable = new datatype[Size: rows, columns ]
datatype variable = arrVariable[row, column] 

Jagged Arrays:
datatype[][] arrVariable = new int[rows][empty]
arrVariable[specify row] = new Type[specify # columns]


Enumerations:
Create Enumeration:
access modifier | enum varEnum {list of values}

Using Enumeration:
varEnum variable = varEnum.(value from the list)
varEnum variable = (varEnum) (element)
int variable = (int)varEnum.(value from the list)

Structures:
Creating a Structure:
datatype struct structName
{
access modifier | datatype variable;  
}

Instantiating a Struct:
structName instanceName = new structName();
instanceName.variable = value;



Constructers:
Adding a Constructer:
Access Modifier | Return Type | Constructer Name 
{
 	This is the custom constructor.
  Access Modifier | Constructer Name(imputing parameters)
   {
      this.variable = value;
   }
   	These statements declare the struct fields and set the default values.
   access modifier | datatype field;

 	Other methods, fields, properties, and events.
}

Calling a Constructer: 
StructName instanceName = new StructName(imputing parameters);







Get/Set:
To create a property that reads and writes to a private field, you can use the following syntax:
public int Strength { get; set; } 
•	To create a property that reads from a private field, you can use the following syntax:
public int Strength { get; } 
•	To create a property that writes to a private field, you can use the following syntax:
public int Strength { set; }
