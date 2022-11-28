using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeGenerator : MonoBehaviour
{

    [SerializeField] Transform[] TreePos;
    public GameObject[] Tree;
    int kindOfTree; 
    [SerializeField] int TreeCount; 
    int posIndex;
     float TreeSize; 
    Vector3 Size; 
    // Start is called before the first frame update

    private void Start()
    {

        GeneratedTrees(); 
  
    }
    void GeneratedTrees()
    {
        TreeCount = Random.Range(10, TreePos.Length - 1);
        for (int i = 0; i <= TreeCount; i++)
        {
            TreeSize = Random.Range(50f, 100f);
            Size = new Vector3(TreeSize, TreeSize, TreeSize);
            kindOfTree = Random.Range(0, Tree.Length - 1);
            posIndex = Random.Range(0, TreePos.Length - 1);
            if (TreePos[posIndex].GetComponent<TreePlaced>().treePlaced == false)
            {
                var tree = Instantiate(Tree[kindOfTree], TreePos[posIndex].localPosition, TreePos[posIndex].localRotation);
                tree.transform.localScale = Size;
                TreePos[posIndex].GetComponent<TreePlaced>().treePlaced = true;
            }


        }
    }


}
