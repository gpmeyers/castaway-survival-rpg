using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_Creator : MonoBehaviour
{
    [System.Serializable]
    public class MultipleTransform
    {
        public Transform[] Transforms;
    }
    
    public Transform[] Hairs;
    public int HairIndex { get; set; }

    public Transform[] Beards;
    public int BeardIndex { get; set; }

    public Transform[] Faces;

    public Transform[] Helmets;
    public int HelmetIndex { get; set; }

    public Transform[] Plastrons;
    public int PlastronIndex { get; set; }

    public MultipleTransform[] Shoulderpads;
    public int ShoulderIndex { get; set; }

    public MultipleTransform[] Kneepads;
    public int KneepadIndex { get; set; }

    public Transform[] Weapons;
    public int WeaponIndex { get; set; }

    public Transform[] Miscs;
    public int MiscIndex { get; set; }

    public Material[] Materials;
    public int MaterialIndex { get; set; }

    private void Update()
    {
        for (int i = 0; i < Hairs.Length; i++)
        {
            if (HelmetIndex != 0)
            {
                Hairs[i].gameObject.SetActive(false);
            }
            else
            {
                if (i != HairIndex)
                    Hairs[i].gameObject.SetActive(false);
                else
                    Hairs[i].gameObject.SetActive(true);
            }
        }

        for (int i = 0; i < Beards.Length; i++)
        {
            if (i != BeardIndex)
                Beards[i].gameObject.SetActive(false);
            else
                Beards[i].gameObject.SetActive(true);
        }

        for (int i = 0; i < Helmets.Length; i++)
        {
            if (i != HelmetIndex)
                Helmets[i].gameObject.SetActive(false);
            else
                Helmets[i].gameObject.SetActive(true);
        }

        for (int i = 0; i < Plastrons.Length; i++)
        {
            if (i != PlastronIndex)
                Plastrons[i].gameObject.SetActive(false);
            else
                Plastrons[i].gameObject.SetActive(true);
        }

        for (int i = 0; i < Hairs.Length; i++)
        {
            if (Hairs[i].GetComponent<MeshRenderer>() != null)
                Hairs[i].GetComponent<MeshRenderer>().material = Materials[MaterialIndex];
        }

        for (int i = 0; i < Faces.Length; i++)
        {
            if (Faces[i].GetComponent<MeshRenderer>() != null)
                Faces[i].GetComponent<MeshRenderer>().material = Materials[MaterialIndex];
        }

        for (int i = 0; i < Beards.Length; i++)
        {
            if (Beards[i].GetComponent<MeshRenderer>() != null)
                Beards[i].GetComponent<MeshRenderer>().material = Materials[MaterialIndex];
        }

        for (int i = 0; i < Shoulderpads.Length; i++)
        {
            if (i != ShoulderIndex)
            {
                for (int x = 0; x < Shoulderpads[i].Transforms.Length; x++)
                    Shoulderpads[i].Transforms[x].gameObject.SetActive(false);
            }
            else
            {
                for (int x = 0; x < Shoulderpads[i].Transforms.Length; x++)
                    Shoulderpads[i].Transforms[x].gameObject.SetActive(true);
            }
        }

        for (int i = 0; i < Kneepads.Length; i++)
        {
            if (i != KneepadIndex)
            {
                for (int x = 0; x < Kneepads[i].Transforms.Length; x++)
                    Kneepads[i].Transforms[x].gameObject.SetActive(false);
            }
            else
            {
                for (int x = 0; x < Kneepads[i].Transforms.Length; x++)
                    Kneepads[i].Transforms[x].gameObject.SetActive(true);
            }
        }

        for (int i = 0; i < Weapons.Length; i++)
        {
            if (i != WeaponIndex)
                Weapons[i].gameObject.SetActive(false);
            else
                Weapons[i].gameObject.SetActive(true);
        }

        for (int i = 0; i < Miscs.Length; i++)
        {
            if (i != MiscIndex)
                Miscs[i].gameObject.SetActive(false);
            else
                Miscs[i].gameObject.SetActive(true);
        }
    }

    private void OnGUI()
    {
        GUILayout.BeginVertical();

        GUILayout.Label("<size=16>Character Creator</size>");

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (HairIndex > 0)
                HairIndex--;
            else
                HairIndex = Hairs.Length - 1;
        }
        GUILayout.Label("Hairs :" + Hairs[HairIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (HairIndex < Hairs.Length - 1)
                HairIndex++;
            else
                HairIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (BeardIndex > 0)
                BeardIndex--;
            else
                BeardIndex = Beards.Length - 1;
        }
        GUILayout.Label("Beards :" + Beards[BeardIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (BeardIndex < Beards.Length - 1)
                BeardIndex++;
            else
                BeardIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (MaterialIndex > 0)
                MaterialIndex--;
            else
                MaterialIndex = Materials.Length - 1;
        }
        GUILayout.Label("Hairiness :" + Materials[MaterialIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (MaterialIndex < Materials.Length - 1)
                MaterialIndex++;
            else
                MaterialIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (HelmetIndex > 0)
                HelmetIndex--;
            else
                HelmetIndex = Helmets.Length - 1;
        }
        GUILayout.Label("Helmets :" + Helmets[HelmetIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (HelmetIndex < Helmets.Length - 1)
                HelmetIndex++;
            else
                HelmetIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (PlastronIndex > 0)
                PlastronIndex--;
            else
                PlastronIndex = Plastrons.Length - 1;
        }
        GUILayout.Label("Plastrons :" + Plastrons[PlastronIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (PlastronIndex < Plastrons.Length - 1)
                PlastronIndex++;
            else
                PlastronIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (ShoulderIndex > 0)
                ShoulderIndex--;
            else
                ShoulderIndex = Shoulderpads.Length - 1;
        }
        GUILayout.Label("Shoulder :" + Shoulderpads[ShoulderIndex].Transforms[0].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (ShoulderIndex < Shoulderpads.Length - 1)
                ShoulderIndex++;
            else
                ShoulderIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (KneepadIndex > 0)
                KneepadIndex--;
            else
                KneepadIndex = Kneepads.Length - 1;
        }
        GUILayout.Label("Knee :" + Kneepads[KneepadIndex].Transforms[0].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (KneepadIndex < Kneepads.Length - 1)
                KneepadIndex++;
            else
                KneepadIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (WeaponIndex > 0)
                WeaponIndex--;
            else
                WeaponIndex = Weapons.Length - 1;
        }
        GUILayout.Label("Weapons :" + Weapons[WeaponIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (WeaponIndex < Weapons.Length - 1)
                WeaponIndex++;
            else
                WeaponIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("<", GUILayout.Width(50)))
        {
            if (MiscIndex > 0)
                MiscIndex--;
            else
                MiscIndex = Miscs.Length - 1;
        }
        GUILayout.Label("Bags :" + Miscs[MiscIndex].name, GUILayout.Width(250));
        if (GUILayout.Button(">", GUILayout.Width(50)))
        {
            if (MiscIndex < Miscs.Length - 1)
                MiscIndex++;
            else
                MiscIndex = 0;
        }
        GUILayout.EndHorizontal();

        GUILayout.BeginHorizontal();
        if (GUILayout.Button("Reset", GUILayout.Width(177)))
        {
            HairIndex = 0;
            BeardIndex = 0;

            HelmetIndex = 0;
            PlastronIndex = 0;
            ShoulderIndex = 0;
            KneepadIndex = 0;

            WeaponIndex = 0;
            MiscIndex = 0;
            MaterialIndex = 0;
        }

        if (GUILayout.Button("Random", GUILayout.Width(177)))
        {
            HairIndex = Random.Range(0, Hairs.Length);
            BeardIndex = Random.Range(0, Beards.Length);

            HelmetIndex = Random.Range(0, Helmets.Length);
            PlastronIndex = Random.Range(0, Plastrons.Length);
            ShoulderIndex = Random.Range(0, Shoulderpads.Length);
            KneepadIndex = Random.Range(0, Kneepads.Length);

            WeaponIndex = Random.Range(0, Weapons.Length);
            MiscIndex = Random.Range(0, Miscs.Length);
            MaterialIndex = Random.Range(0, Materials.Length);
        }
        GUILayout.EndHorizontal();

        GUILayout.EndVertical();
    }
}