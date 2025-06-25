using UnityEngine;

public class Lanceiro : Personagem
{
    public string arma = "Lança longa";
    public string habilidade = "Golpe Perfurante";

    public void UsarHabilidade()
    {
        Debug.Log(nome + " usou " + habilidade + " com a " + arma);
    }
}