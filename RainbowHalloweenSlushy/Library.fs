namespace RainbowHalloweenSlushy

open UnityEngine

type ButtonManager() =
   inherit MonoBehaviour()
   
   [<SerializeField>]
   [<DefaultValue>] val mutable _informationText : GameObject

    member this.Start() = 
        Debug.Log("F# ")

    member this.Update() = 
        Debug.Log("hello man")

