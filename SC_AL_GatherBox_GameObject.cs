using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SO_AL_GatherBox_GameObject", menuName = "스크립터블 추가/_AL_GatherBox_GameObject")]
public class SC_AL_GatherBox_GameObject : ScriptableObject
{
    public List<GameObject> GameObject_List = new List<GameObject>();

}