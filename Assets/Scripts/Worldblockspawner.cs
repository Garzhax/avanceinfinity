using UnityEngine;

public class Worldblockspawner : MonoBehaviour
{
    [SerializeField] GameObject[] blocks;    // Bloques de piso
    [SerializeField] GameObject[] items;    // Ítems recolectables (nuevo)
    public Transform spawnPoint;             // Punto de spawn

    [Header("Configuración de Ítems")]
    [Range(0, 1)] public float itemSpawnChance = 0.3f; // 30% de probabilidad
    public float itemYOffset = 1.5f;        // Altura de los ítems (sobre el bloque)

    void Start()
    {
        SpawnBlock();
        InvokeRepeating("SpawnBlock", 0, 1f); // Genera bloques cada 1 segundo
    }

    public void SpawnBlock()
    {
        // 1. Spawn del bloque
        int randomBlockIndex = Random.Range(0, blocks.Length);
        GameObject block = Instantiate(blocks[randomBlockIndex], spawnPoint.position, Quaternion.identity);
        block.transform.SetParent(transform);

        // 2. Spawn de ítem (opcional)
        if (items.Length > 0 && Random.value <= itemSpawnChance)
        {
            int randomItemIndex = Random.Range(0, items.Length);
            Vector3 itemPosition = new Vector3(
                spawnPoint.position.x + Random.Range(-2f, 2f), // Posición X aleatoria
                spawnPoint.position.y + itemYOffset,           // Altura fija o aleatoria
                spawnPoint.position.z
            );

            GameObject item = Instantiate(items[randomItemIndex], itemPosition, Quaternion.identity);
            item.transform.SetParent(transform); // Opcional (para orden jerárquico)
        }
    }
}