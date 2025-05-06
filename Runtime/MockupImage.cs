using UnityEngine;
using UnityEngine.UI;

namespace Five.UI
{
    public class MockupImage : MonoBehaviour
    {
        [SerializeField] private Image image;

        public void SetOpaque()
        {
            Color color = image.color;
            color.a = 1f; // Set the alpha value to 1 (opaque)
            image.color = color;
        }

        public void SetTransparent()
        {
            Color color = image.color;
            color.a = 0.3f;
            image.color = color;
        }
    }
}
