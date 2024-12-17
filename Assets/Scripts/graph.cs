using UnityEngine;
using System.Collections.Generic;

[System.Serializable]
struct Node
{
    public List<Node> neighbors;
    public int local = 0;
    public int neutral = 0;
    public int opposite = 0;
    public Vector3 position;
    public int nodeId;
}

class Graph
{
    public List<Node> nodes;
}

[CreateAssetMenu(fileName = "NodePositions", menuName = "Graph/Node Positions")]
public class NodePositions : ScriptableObject
{
    public List<Node> positions = new List<Node>();
}