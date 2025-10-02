using System.Collections.Generic;
using UnityEngine;

public class LabFourHelper : MonoBehaviour
{

    [SerializeField] Material lambert;
    [SerializeField] Material specular;


    [SerializeField] List<MeshRenderer> meshes = new();

    [SerializeField] GameObject objectHolder;
    [SerializeField] float spinSpeed;

 

    public void ChangeMaterial(Material material)
    {
        foreach (var mesh in meshes)
        {
            mesh.material = material;
        }
    }

    private void Update()
    {
        foreach (var mesh in meshes)
        {
            mesh.transform.rotation = Quaternion.Euler(spinSpeed * Time.deltaTime, 0, 0);
        }
    }
}
