namespace GoogleVR.HelloVR
{
    using UnityEngine;
    public class Teleporter : MonoBehaviour
    {

        //private Vector3 startingPosition;
        private Renderer myRenderer;

        public Material inactiveMaterial;
        public Material gazedAtMaterial;

        public AudioClip clickSound;
        private AudioSource audiosource;

        private void Awake()
        {
            audiosource = gameObject.GetComponent<AudioSource>();
            audiosource.clip = clickSound;
            audiosource.playOnAwake = false;
        }

        void Start()
        {
            //startingPosition = transform.localPosition;
            myRenderer = GetComponent<Renderer>();
            SetGazedAt(false);
        }

        public void SetGazedAt(bool gazedAt)
        {
            if (inactiveMaterial != null && gazedAtMaterial != null)
            {
                myRenderer.material = gazedAt ? gazedAtMaterial : inactiveMaterial;
                return;
            }
        }

        public void TeleportTo()
        {
            audiosource.Play();

            Camera.main.transform.parent.transform.position = gameObject.transform.position;

            if (GameManager.Instance.playerStatus == status.idle)
            {
                GameManager.Instance.StartedSolving();
            }
        }

    }
}
