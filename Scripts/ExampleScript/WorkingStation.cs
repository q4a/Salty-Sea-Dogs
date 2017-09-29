using UnityEngine;
using System.Collections;

namespace InventoryMaster
{
    [RequireComponent(typeof(Collider))]
    public class WorkingStation : MonoBehaviour
    {

        public KeyCode openInventory;
        public GameObject craftSystem;
        public int distanceToOpenWorkingStation = 3;
        bool showCraftSystem;
        Inventory craftInventory;
        CraftSystem cS;

        [SerializeField]
        ItemCategory[] itemCategories;

        Collider triggerCollider;

        // Use this for initialization
        void Start()
        {
            if (craftSystem != null)
            {
                craftInventory = craftSystem.GetComponent<Inventory>();
                cS = craftSystem.GetComponent<CraftSystem>();
            }
            triggerCollider = GetComponent<Collider>();
        }

        private void OnTriggerExit(Collider other)
        {
            if (showCraftSystem)
            {
                cS.backToInventory();
                craftInventory.closeInventory();
            }
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyUp(openInventory) && (triggerCollider.isTrigger && triggerCollider.bounds.Contains(GameObject.FindGameObjectWithTag("Player").transform.position)))
            {
                showCraftSystem = !showCraftSystem;
                if (showCraftSystem)
                {
                    craftInventory.openInventory();
                }
                else
                {
                    cS.backToInventory();
                    craftInventory.closeInventory();
                }
            }
        }
    }
}
