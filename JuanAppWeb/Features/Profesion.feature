# language: es
Característica: Profesion
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Calculadora simple para sumar dos números
Link to a feature: [Calculator](SpecFlowTest/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Escenario: Datos 
	Dado que el nombre es "Juan"
	Y su apellido es "Rocha"
	Cuando los datos son
	Entonces el resultado debe sera "JuanRocha"

	Escenario: Profesion Datos
	Dado que la profesion es "Medico"
	Y la seccion a la pertence es "Cardiologia"
	Cuando sus datos de profesion son
	Entonces el resultado es "MedicoCardiologia"