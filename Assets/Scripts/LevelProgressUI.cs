using UnityEngine ;
using UnityEngine.UI ;

public class LevelProgressUI : MonoBehaviour {

   [Header ("UI references :")]
   [SerializeField] private Image uiFillImage ;
   [SerializeField] private Text uiStartText ;
   [SerializeField] private Text uiEndText ;

   [Header ("Player & Endline references :")]
   [SerializeField] private Transform playerTransform ;
   [SerializeField] private Transform endLineTransform ;

   
   private Vector3 endLinePosition ;

   private float fullDistance ;


   private void Start () {
      endLinePosition = endLineTransform.position ;
      fullDistance = GetDistance () ;
   }


   public void SetLevelTexts (int level) {
      uiStartText.text = level.ToString () ;
      uiEndText.text = (level + 1).ToString () ;
   }


   private float GetDistance () {
      return (endLinePosition - playerTransform.position).sqrMagnitude ;
   }


   private void UpdateProgressFill (float value) {
      uiFillImage.fillAmount = value ;
   }


   private void Update () {
   
      if (playerTransform.position.z <= endLinePosition.z) {
         float newDistance = GetDistance () ;
         float progressValue = Mathf.InverseLerp (fullDistance, 0f, newDistance) ;

         UpdateProgressFill (progressValue) ;
      }
   }
}
