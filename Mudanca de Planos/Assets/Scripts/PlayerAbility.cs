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
    [Header("Mage")]
    [SerializeField] float abilityMageCoolDown;
    [SerializeField] GameObject fireBallPrefab;
    [SerializeField] Transform magicPosition;
    AbilityMageType mageAbility;


    [Header("Shilder")]
    [SerializeField] float abilityShilderCoolDown;
    [SerializeField] GameObject shieldPrefab;
    [SerializeField] Transform shilderPosition;
    AbilityShilderType shilderAbility;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MageCharacter();
        ShilderCharacter();
    }

    public void MageCharacter()
    {
        if (Input.GetAxisRaw("Fire1") != 0)
        {
            SetMageAbility(AbilityMageType.Fireball);
            abilityMageCoolDown -= Time.deltaTime;
        }
    }

    public void ShilderCharacter()
    {
        if (Input.GetAxisRaw("Fire2") != 0)
        {
            SetShilderAbility(AbilityShilderType.ShieldBlock);
            
        }
    }

    public void SetMageAbility(AbilityMageType modeMage)
    {
        switch (modeMage) 
        {
            case AbilityMageType.Fireball:
                Instantiate(fireBallPrefab, magicPosition);
                abilityMageCoolDown -= Time.deltaTime;
                break;
            
            case AbilityMageType.HellingWave:
                abilityMageCoolDown -= Time.deltaTime;

                break;

            case AbilityMageType.None:
            break;

        }
    }


    
    public void SetShilderAbility(AbilityShilderType modeShilder)
    {
        switch (modeShilder)
        {
            case AbilityShilderType.ShieldBlock:    
                Instantiate(shieldPrefab, shilderPosition);
                abilityShilderCoolDown -= Time.deltaTime;
            break;
            case AbilityShilderType.EarthQuake:
                abilityShilderCoolDown -= Time.deltaTime;
                break;
            case AbilityShilderType.None:
            break;
        }

        
    }

    

    
}
