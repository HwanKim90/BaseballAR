using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class StadiumMove : MonoBehaviour
{
    public List<GameObject> startPosList;
    public float moveObjSpeed = 10f;

    List<GameObject> movePosList = new List<GameObject>();
    
    void Start()
    {
        InputPositionInMoveList();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RandomMoveGameObjects();
        }
    }

    void InputPositionInMoveList()
    {
        for (int i = 0; i < startPosList.Count; i++)
        {
            movePosList.Add(startPosList[i]);
        }
    }

    void RandomMoveGameObjects()
    {
        print(movePosList.Count);
        for (int i = 0; i < movePosList.Count; i++)
        {
            Vector3 temp;
            temp = movePosList[i].transform.position;
            print(temp);
            movePosList[i].transform.position = movePosList[i + 1].transform.position;
            movePosList[i + 1].transform.position = temp;
            print("i : " + i);
        }
    }

    void MoveSwapAni(GameObject origin, GameObject target)
    {
        iTween.MoveTo(target, iTween.Hash(
            ""
        ));
    }
           
            


    
    
}
