using UnityEngine;

public class Personagem : MonoBehaviour
{
    public string nome;
    public int nivel;
    public float vida;
    public float ataque;

    public void MostrarInfo()
    {
        Debug.Log("Nome: " + nome);
        Debug.Log("Nível: " + nivel);
        Debug.Log("Vida: " + vida);
        Debug.Log("Ataque: " + ataque);
    }

    public void CompararAtaque(Personagem outro)
    {
        if (ataque > outro.ataque)
        {
            Debug.Log(nome + " tem mais ataque que " + outro.nome);
        }
        else if (ataque < outro.ataque)
        {
            Debug.Log(outro.nome + " tem mais ataque que " + nome);
        }
        else
        {
            Debug.Log(nome + " e " + outro.nome + " têm o mesmo ataque");
        }
    }
    
}