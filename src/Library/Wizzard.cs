using System;
namespace library;

public class Wizzard {
    private double vida {get; set;}
    private String nombre {get; set;}
    private String item {get; set;}

    public Wizzard(double vida, String nombre){
        this.vida = vida;
        this.nombre = nombre;
    }

    public void AgregarItem(String Item){
        this.item = item;
    }

    public void RecibirDaño()
}