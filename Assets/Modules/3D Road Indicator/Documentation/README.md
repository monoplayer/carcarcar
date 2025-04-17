## Road Indicator Manager

The `RoadIndicatorManager` is a C# script designed to draw a road indicators within a Unity project. It allows for the creation, cancellation, and management of paths between various points in the game world.

### Usage

1. **Drag and Drop**: `Road Indicator` in your scene.
2. **Attach Script**:
    - **Player Indicator**: Assign a `PlayerIndicator` to the player GameObject.
3. **Create Location Indicators**:
    - Create an object or just assign `LocationIndicator` to the point you want the player to go.
    - Customize each LocationIndicator with a unique ID.
    - If you have more than one location that represent one location such as multiple marketplaces make duplicate `true` so that when trying to set path it will select the nearest one to the `PlayerIndicator`.
4. **Set Path**
    - Call the `SetIndicator(string id)` method with the desired location ID that assigned in `LocationIndicator` to create a path from the player's current position.
5. **Cancel Indicator Path**:
    - Call the `CancelIndicator(string id)` method to cancel the path to a specific destination.
    - Example: `RoadIndicatorManager.CancelIndicator("destination_id");`
6. **Events**
    -  `OnPathCompleted` you can subscribe to `OnPathCompleted` to fire any custom scripts when player reached his destination.
    -  `OnPathCanceled` you can subscribe to `OnPathCanceled` to fire any custom scripts when player cancel his destination.

### Example

```csharp
using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Set indicator path to a destination with ID "destination_id"
        RoadIndicatorManager.SetIndicator("destination_id");
        RoadIndicatorManager.OnPathCompleted.AddListener((location) =>
        {
          Debug.Log($"Arrived at {location.name}");
        });
    }

    // Update is called once per frame
    void Update()
    {
        // Check for input to cancel indicator path
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            RoadIndicatorManager.CancelIndicator("destination_id");
        }
    }
}
```

In this example, the `SetIndicator` method is called in the `Start` method to create a path to a destination with the ID "destination_id". The `CancelIndicator` method is called when the Escape key is pressed to cancel the path to the same destination.