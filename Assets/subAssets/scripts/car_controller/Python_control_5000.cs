using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AustinHarris.JsonRpc;

public class Python_control_5000 : MonoBehaviour
{
    public PrometeoCarController PrometeoCarController; // Make sure the class is public
    public RpcService rpc;

    // Start is called before the first frame update
    void Start()
    {
        PrometeoCarController = GetComponent<PrometeoCarController>();
        rpc = new RpcService(this);
    }

    // Update is called once per frame
    void Update()
    {

    }

    // Custom RPC service class for controls
    public class RpcService : JsonRpcService
    {
        private Python_control_5000 controller; // Use the correct class name here

        public RpcService(Python_control_5000 controller) // Use the correct class name here
        {
            this.controller = controller;
        }

        [JsonRpcMethod]
        public void GoForward_5000()
        {
            controller.PrometeoCarController.GoForward();
        }

        [JsonRpcMethod]
        public void GoReverse_5000()
        {
            controller.PrometeoCarController.GoReverse();
        }

        [JsonRpcMethod]
        public void TurnLeft_5000()
        {
            controller.PrometeoCarController.TurnLeft();
        }

        [JsonRpcMethod]
        public void TurnRight_5000()
        {
            controller.PrometeoCarController.TurnRight();
        }

        [JsonRpcMethod]
        public void ResetSteeringAngle_5000()
        {
            controller.PrometeoCarController.ResetSteeringAngle();
        }

        [JsonRpcMethod]
        public void ThrottleOff_5000()
        {
            controller.PrometeoCarController.ThrottleOff();
        }

        [JsonRpcMethod]
        public void Handbrake_5000()
        {
            controller.PrometeoCarController.Handbrake();
        }

        [JsonRpcMethod]
        public void RecoverTraction_5000()
        {
            controller.PrometeoCarController.RecoverTraction();
        }

        [JsonRpcMethod]
        public float CarSpeedUI_5000()
        {
            controller.PrometeoCarController.CarSpeedUI();
            float speed = controller.PrometeoCarController.carSpeed; // Assuming 'carSpeed' is a public variable in the 'PrometeoCarController' class
            // print(speed);
            return speed;
        }
    }
}
