using TMPro;
using UnityEngine;

namespace Leap.Unity.Examples
{
    public class PoseDetectorUIText : MonoBehaviour
    {
        public GameObject textGameobject;
        public TextMeshProUGUI text;

        [Header("References")]
        public HandPoseDetector[] detectors;

        private HandPoseScriptableObject prev;

        void Update()
        {
            HandPoseScriptableObject detectedPose = null;
            for (int i = 0; i < detectors.Length; i++)
            {
                if (detectors[i].GetCurrentlyDetectedPose() != null)
                {
                    detectedPose = detectors[i].GetCurrentlyDetectedPose();
                    break;
                }
            }
            if (detectedPose != null && prev != detectedPose)
            {
                textGameobject.SetActive(true);
                string txt = "";
                if (detectedPose.name == "point_up")
                {
                    txt = "HEADING UP";
                }
                if (detectedPose.name == "stop")
                {
                    txt = "STOP HERE";
                }
                if (detectedPose.name == "ok")
                {
                    txt = "ROGER THAT";
                }
                text.text = "#438.500 (You):\n" + txt;
            }
            prev = detectedPose;

        }
    }
}