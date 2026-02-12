using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using System;


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
    [SerializeField] GameObject shieldPrefab;
    AbilityShilderType shilderAbility;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerId == 1)
        {
            SetMageAbility(AbilityMageType.Fireball);
            SetMageAbility(AbilityMageType.HellingWave);
        }else if(playerId == 2)
        {
            SetShilderAbility(AbilityShilderType.ShieldBlock);
            SetShilderAbility(AbilityShilderType.EarthQuake);
        }


                
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


    IEnumerator CooldownMageAbility(AbilityMageType modeMage)
    {
        yield return new WaitForSeconds(abilityMageCoolDown);
    }
    public void SetShilderAbility(AbilityShilderType modeShilder)
    {
        switch (modeShilder)
        {
            case AbilityShilderType.ShieldBlock:    
                Instantiate(shieldPrefab);
                StartCoroutine(ShilderCooldown(modeShilder));
            break;
            case AbilityShilderType.EarthQuake:
                StartCoroutine(ShilderCooldown(modeShilder));
            break;
            case AbilityShilderType.None:
            break;
        }
    }

    IEnumerator ShilderCooldown(AbilityShilderType modeShilder)
    {
        yield return new WaitForSeconds(abilityShilderCoolDown);
    }
}
