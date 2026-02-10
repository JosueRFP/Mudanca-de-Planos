using System.Collections;
using Unity.VisualScripting;
using UnityEngine;


public enum AbilityMageType
{
    None,
    Fireball,
    HellingWave
}

public enum AbilityShilderType
{
    None,
    ShieldBlock,
    EarthQuake
}
public class PlayerAbility : MonoBehaviour
{
    [SerializeField] int playerId;
    [Header("Mage")]
    [SerializeField] float abilityMageCoolDown;
    [SerializeField] GameObject fireBallPrefab;
    AbilityMageType mageAbility;


    [Header("Shilder")]
    [SerializeField] float abilityShilderCoolDown;
    AbilityShilderType shilderAbility;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator CooldownMageAbility(AbilityMageType modeMage)
    {
        yield return new WaitForSeconds(abilityMageCoolDown);
    }

    public void SetMageAbility(AbilityMageType modeMage)
    {
        switch (modeMage) 
        {
            case AbilityMageType.Fireball:
                Instantiate(fireBallPrefab);
                StartCoroutine(CooldownMageAbility(modeMage));
            break;
            
            case AbilityMageType.HellingWave:
                
                StartCoroutine(CooldownMageAbility(modeMage));
            break;

            case AbilityMageType.None:
            break;

        }
    }
}
