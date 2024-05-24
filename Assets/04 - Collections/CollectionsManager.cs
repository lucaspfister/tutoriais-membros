using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectionsManager : MonoBehaviour
{
    private void Start()
    {
        int[] array = new int[5];

        List<int> list = new(52);
        list.Add(45);

        int card = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);

        for (int i = 0; i < list.Count; i++)
        {
            Debug.Log(list[i]);
        }

        Stack<string> stack = new(52);
        stack.Push("A");
        stack.Push("B");

        //string item = stack.Pop();
        //Debug.Log(item);
        //Debug.Log(stack.Count);

        Queue<string> queue = new();
        queue.Enqueue("A");
        queue.Enqueue("B");

        //Debug.Log(queue.Dequeue());
        //Debug.Log(queue.Count);
        //Debug.Log(queue.Dequeue());
        //Debug.Log(queue.Count);





        Player player1 = new Player()
        {
            Id = "ALSKDJALSKDJ-ADASJKLDJALSKD-ASDJASDLKJ42345",
            Name = "Unity",
        };

        Player player2 = new Player()
        {
            Id = "PLAYER 1",
            Name = "Gamarra",
        };

        Dictionary<string, Player> dict = new();
        dict.Add(player1.Id, player1);
        dict.Add(player2.Id, player2);

        //foreach (var item in dict)
        //{
        //    Debug.Log(item.Value.Name);
        //}

        Player player = dict["PLAYER 0"];
        Debug.Log(player.Name);
    }
}

public struct Player
{
    public string Id;
    public string Name;
}
