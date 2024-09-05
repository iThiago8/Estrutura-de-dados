using System.Collections;
using System.Collections.Generic;

//Utilizando a lista simples
ArrayList arrList = [];
arrList.Add(5);
arrList.Add("Thiago");
arrList.AddRange(new int[] { 1, 2, 3 });
//Método Add() coloca no final da lista

arrList.Insert(1, 15);
//Método Insert() coloca na posição especificada e empurra os que estão à direita 

arrList[1] = 4;
//Via indexador, o valor antigo é substituído

//Lendo valores da lista
object primeiro = arrList[0]!;
int quarto = (int)arrList[3]!;

// percorrendo a lista com foreach
foreach (var obj in arrList)
{
    Console.WriteLine(obj);
}


