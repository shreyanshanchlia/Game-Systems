using UnityEngine;
using UnityEngine.Events;

namespace SDG
{
    public class HorizontalSelector : MonoBehaviour
    {
        public int AmountOfItems;
        [Header("Link event to set values")]
        public UnityEvent ApplyValues;

        int selectedItemNumber;

        private void SetItems()
        {
            // initialize all variables to UI here.
            ApplyValues.Invoke();
        }
        public void NextItem()
        {
            selectedItemNumber = (selectedItemNumber + 1) % AmountOfItems;
        }
        public void PreviousItem()
        {
            selectedItemNumber = (selectedItemNumber - 1) % AmountOfItems;
        }
    }
}
