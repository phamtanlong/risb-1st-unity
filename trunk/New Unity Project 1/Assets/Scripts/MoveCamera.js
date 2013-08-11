var mDelta = 10; // Pixels. The width border at the edge in which the movement work
var mSpeed = 3.0; // Scale. Speed of the movement
var xSensitivity = 100.0;
var ySensitivity = 100.0;

 

var initialTarget : Transform;
private var pivotCameraSpace : Vector3 = Vector3.zero;

function Start()
{
    //if (initialTarget)
    //    SetPivotPoint( initialTarget.position );
}


function SetPivotPoint( pivotWorldPos : Vector3 )
{
    // If you do not want the camera to actually look at the pivot point,
    // uncomment the following line
    //transform.LookAt( pivotWorldPos, transform.up );
    
    //pivotCameraSpace = transform.InverseTransformPoint( pivotWorldPos );
}

function LateUpdate ()
{
   // Omars "change position part"
   // Check if on the right edge
   if ( Input.mousePosition.x >= Screen.width - mDelta )
   {
      // Move the camera
      transform.position += transform.right * Time.deltaTime * mSpeed;
   }

   if ( Input.mousePosition.x <= 0 + mDelta )
   {
      // Move the camera
      transform.position -= transform.right * Time.deltaTime * mSpeed;
   }

   if ( Input.mousePosition.y >= Screen.height - mDelta )
   {
      // Move the camera
      transform.position += transform.up * Time.deltaTime * mSpeed;
   }

   if ( Input.mousePosition.y <= 0 + mDelta )
   {
      // Move the camera
      transform.position -= transform.up * Time.deltaTime * mSpeed;
   }
   
   /*
    // Changing an angle, if mouse button is held   
   if (Input.GetMouseButton(1) )
    {
      // Update x, y angle with the mouse delta
      xAngleChange = Input.GetAxis ("Mouse X") * xSensitivity * Time.deltaTime;
      yAngleChange = Input.GetAxis ("Mouse Y") * ySensitivity * Time.deltaTime;

      // rotate 
      var pivotWorldPos : Vector3 = transform.TransformPoint( pivotCameraSpace );
      transform.rotation = transform.rotation * 
      Quaternion.Euler(-yAngleChange, xAngleChange, 0);
      // Adjust position, if the pivotpoint moved relative to us
      transform.position += pivotWorldPos - transform.TransformPoint( pivotCameraSpace );
   }
   */
}