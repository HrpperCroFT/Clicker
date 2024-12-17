using UnityEngine;

public class graph_illustarate : MonoBehaviour
{
    public Graph graph;
    [SerializeField] private NodePositions nodePositions;

    void Start()
    {
        CreateNodesFromPositionsFile();
        CreateEdges();
    }

    private void CreateNodesFromPositionsFile()
    {
        if (nodePositions == null)
        {
            Debug.LogError("NodePositions не назначен!");
            return;
        }

        foreach (var nodePosition in nodePositions.positions)
        {
            GameObject newNode = Instantiate(nodePrefab, nodePosition.position, Quaternion.identity);
            newNode.transform.SetParent(transform);
            Node nodeScript = newNode.GetComponent<Node>();
            nodeScript.SetId(nodePosition.nodeId);
            nodes.Add(nodeScript);
        }
    }

}