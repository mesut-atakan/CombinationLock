using UnityEngine;



internal class CombinationLock : MonoBehaviour
{
#region ||~~~~~~~|| SERIALIZE FIELDS ||~~~~~~~||

    [SerializeField] private Transform numeric1_Transform, numeric2_Transform, numeric3_Transform, numeric4_Transform;
    [SerializeField] private byte plusValue = 36;


    [SerializeField] private byte numeric1_value, numeric2_value, numeric3_value, numeric4_value;


    [SerializeField] private ushort truePassword;

#endregion ||~~~~~~~|| XXXX ||~~~~~~~||












    public void Rotate1Numeric()
    {
        if (numeric1_value < 9)
        {
            numeric1_value++;
            numeric1_Transform.transform.localRotation = Quaternion.Euler(0,0, this.numeric1_Transform.transform.localRotation.z + (numeric1_value * plusValue));

        }
        else
        {
            numeric1_Transform.transform.localRotation = Quaternion.Euler(0,0,0);
            numeric1_value = 0;
        }
    }


    public void Rotate2Numeric()
    {
        if (numeric2_value < 9)
        {
            numeric2_value++;
            numeric2_Transform.transform.localRotation = Quaternion.Euler(0,0, this.numeric2_Transform.transform.localRotation.z + (numeric2_value * plusValue));

        }
        else
        {
            numeric2_Transform.transform.localRotation = Quaternion.Euler(0,0,0);
            numeric2_value= 0;
        }
    }



    public void Rotate3Numeric()
    {
        if (numeric3_value < 9)
        {
            numeric3_value++;
            numeric3_Transform.transform.localRotation = Quaternion.Euler(0,0, this.numeric3_Transform.transform.localRotation.z + (numeric3_value * plusValue));

        }
        else
        {
            numeric3_Transform.transform.localRotation = Quaternion.Euler(0,0,0);
            numeric3_value = 0;
        }
    }



    public void Rotate4Numeric()
    {
        if (numeric4_value < 9)
        {
            numeric4_value++;
            numeric4_Transform.transform.localRotation = Quaternion.Euler(0,0, this.numeric4_Transform.transform.localRotation.z + (numeric4_value * plusValue));

        }
        else
        {
            numeric4_Transform.transform.localRotation = Quaternion.Euler(0,0,0);
            numeric4_value = 0;
        }
    }





    internal void ResetLock()
    {
        numeric1_value = 0;
        numeric2_value = 0;
        numeric3_value = 0;
        numeric4_value = 0;


        numeric1_Transform.localRotation = Quaternion.Euler(0, 0, 0);
        numeric2_Transform.localRotation = Quaternion.Euler(0, 0, 0);
        numeric3_Transform.localRotation = Quaternion.Euler(0, 0, 0);
        numeric4_Transform.localRotation = Quaternion.Euler(0, 0, 0);
    }







    internal void RandomPassword()
    {
        this.truePassword = (ushort)Random.Range(1000, 9999);
    }



    internal void EnterPassword()
    {
        // ~~ Variables ~~
        string currentPassword = $"{this.numeric1_value}{this.numeric2_value}{this.numeric3_value}{this.numeric4_value}";

        if (int.TryParse(currentPassword, out int convertPassword))
        {
            if (convertPassword == this.truePassword) {
                Debug.Log("<color=yellow>TRUE PASSWORD!</color>", this.gameObject);
            }
            else{
                Debug.Log("<color=red>FALSE PASSWORD!</color>", this.gameObject);
            }
        }
        else{
            Debug.Log("<color=red>ERROR!</color> The conversion process is successful! <i><color=gray><PASSWORD></color></i>", this.gameObject);
        }
    }


    internal void RandomLockValue()
    {
        this.numeric1_value = (byte)Random.Range(0, 10);
        this.numeric2_value = (byte)Random.Range(0, 10);
        this.numeric3_value = (byte)Random.Range(0, 10);
        this.numeric4_value = (byte)Random.Range(0, 10);
    }



    internal void LockValueTransformEqualing()
    {
        this.numeric1_Transform.transform.localRotation = Quaternion.Euler(0, 0, this.numeric1_Transform.transform.localRotation.z + (numeric1_value * plusValue));
        this.numeric2_Transform.transform.localRotation = Quaternion.Euler(0, 0, this.numeric2_Transform.transform.localRotation.z + (numeric2_value * plusValue));
        this.numeric3_Transform.transform.localRotation = Quaternion.Euler(0, 0, this.numeric3_Transform.transform.localRotation.z + (numeric3_value * plusValue));
        this.numeric4_Transform.transform.localRotation = Quaternion.Euler(0, 0, this.numeric4_Transform.transform.localRotation.z + (numeric4_value * plusValue));
    }
}