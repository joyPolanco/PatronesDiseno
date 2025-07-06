// See https://aka.ms/new-console-template for more information
Console.WriteLine("Elige el equipo a utilizar [1]Mac [2] Windows");

int opcion= int.Parse(Console.ReadLine());
FabricaUI fabricaUI;
if(opcion==1) {
fabricaUI= new FabricaMac();}

else if(opcion==2){
    fabricaUI= new FabricaWindows();
}
else {
    fabricaUI=null;
}
IBoton boton;
IMenu menu;
if (fabricaUI != null)
{
    boton = fabricaUI.CrearBoton();
    menu = fabricaUI.CrearMenu();
    boton.Mostrar();
    menu.Mostrar();
     

}


