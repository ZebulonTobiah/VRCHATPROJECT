using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Valve.VR.InteractionSystem
{
    //-------------------------------------------------------------------------
    [RequireComponent(typeof(Interactable))]
    public class Gun : MonoBehaviour
    {

        private Hand hand;

        public SoundPlayOneshot fire;

        SteamVR_Events.Action newPosesAppliedAction;


        //-------------------------------------------------
        private void OnAttachedToHand(Hand attachedHand)
        {
            hand = attachedHand;
        }


        //-------------------------------------------------
        private void OnHandFocusLost(Hand hand)
        {
            gameObject.SetActive(false);
        }


        //-------------------------------------------------
        private void OnHandFocusAcquired(Hand hand)
        {
            gameObject.SetActive(true);
            OnAttachedToHand(hand);
        }


        //-------------------------------------------------
        private void OnDetachedFromHand(Hand hand)
        {
            Destroy(gameObject);
        }


        //-------------------------------------------------
        void OnDestroy()
        {

        }
    }
}