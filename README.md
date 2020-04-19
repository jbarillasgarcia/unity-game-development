# Unity Game Development
Introduction to game development with Unity and C#.

## Environment Configuration
* Microsoft Visual Studio Community 2019 16.5.3
* Unity 2018.4.21f1 Personal
* Oculus Go 64 GB
* Xbox Elite Wireless Controller Series 2

## Basic Classes
* MonoBehaviour
* Vector3

### Class MonoBehaviour
This class must be derived in all Unity scripts. It allows scripts to implement basic functions like awake, start, update or response to input events. 

### Class Vector3
Stores vector components (x, y, z) of a position in a three dimensions coordinate system.

## MonoBehaviour Class Members
- **Awake** method used to initialize class variables; access to other components in the scene is not guaranteed.
- **Start** method all objects in the scene are already initialized.
- **Update** method get called on every single frame.
- **FixedUpdate** method gets called on a fixed period of time, let´s say every 0.2 seconds.
- **LateUpdate** method gets called at the end of every single frame.
- **OnDisable** method gets called when the object is disabled.
- **OnEnable** method gets called when the object is enabled.

## Console Output
You can write text to the output console using the static method *Log(...)* from *Debug* class as follows:

```sh
Debug.Log("Put your messsage here!!!");
```
