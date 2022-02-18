using UnityEngine ;

public class Player : MonoBehaviour {

   [SerializeField] private float speed = 10f ;


   private void Update () {

      float x = Input.GetAxis ("Horizontal") ;
      float z = Input.GetAxis ("Vertical") ;

      transform.position += new Vector3 (x, 0, z) * speed * Time.deltaTime ;

   }


}
