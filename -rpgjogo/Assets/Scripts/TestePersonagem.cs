using UnityEngine;

public class Teste : MonoBehaviour
{
    void Start()
    {
        Lanceiro l1 = new Lanceiro();
        l1.nome = "Ragnar";
        l1.nivel = 10;
        l1.vida = 100f;
        l1.ataque = 25f;

        Personagem inimigo = new Personagem();
        inimigo.nome = "Goblin";
        inimigo.nivel = 3;
        inimigo.vida = 50f;
        inimigo.ataque = 10f;

        l1.MostrarInfo();
        inimigo.MostrarInfo();

        l1.CompararAtaque(inimigo);
        l1.UsarHabilidade();
    }
}