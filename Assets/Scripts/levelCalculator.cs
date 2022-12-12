using UnityEngine;

public class levelCalculator : MonoBehaviour
{
    void Update()
    {
        if (globalVars.last10 >= 10)
        {
            //70% success rate or higher
            if(globalVars.last10Score >= 7)
            {
                globalVars.spawnSpeed *= 0.9f;
                globalVars.level++;
            }else if(globalVars.last10Score <= 4){ //sucess rate of 40% or lower
                globalVars.spawnSpeed *= 1.1f;
                globalVars.level--;
            }
            globalVars.last10 = 0;
            globalVars.last10Score = 0;
        }
    }
}
