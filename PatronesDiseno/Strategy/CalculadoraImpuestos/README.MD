Calculadora de Impuestos para Nómina

Desarrolla una calculadora de impuestos para nómina que permita calcular los impuestos sobre el salario de diferentes tipos de empleados en una empresa. 

La aplicación debe ofrecer opciones de cálculo de impuestos específicas según el tipo de empleado y ser flexible para facilitar la adición de nuevos tipos de cálculo en el futuro.

Requerimientos Funcionales

A) Creación de empleados
El sistema debe permitir crear empleados, tomando en cuenta que hay 3 tipos de empleados:

Empleado de Tiempo Completo
Por contrato
Empleado a Medio Tiempo
Analice y determine los atributos que necesitará.


B) Cálculo de impuestos
El sistema debe permitir calcular el impuesto sobre el salario bruto de diferentes tipos de empleados:
Empleado de Tiempo Completo: Aplica una tasa de impuestos del 25%.
Por contrato: Aplica una tasa de impuestos del 15%.
Empleado a Medio Tiempo: Aplica una tasa de impuestos del 10%.
C) Exportar.

Incluir una opción para que el usuario de la aplicación exporte los datos de los empleados, incluyendo el impuesto calculado, atendiento a estos requerimientos:

Se puede exportar a Excel, JSON y TXT
El usuario podra elegir en cual de los 3 formatos lo desea
Ponga que el archivo sea creado en la misma raiz del proyecto.
Los datos a exportar son estos:
Nombre | Tipo empleado | Salario | Impuesto

Requerimientos de diseño
Implemente el patrón de diseño Strategy en la creación de los empleados y en la exportación
Puede realizarlo en Consola o API, según prefiera.