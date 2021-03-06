using System;

interface IButtonListSelector
{
    int DefaultIndex { get; set; }

    bool Focused { get; set; }

    ButtonList ButtonList { get; set; }

    void UpdateButtonListSelection(int index);

    int UpdateSelectedIndex();

    string EvaluateCurrentSelection();
    
    void PlaySelectSFX();

    void PlayConfirmSFX();

    void SelectorBegin();

    void SelectorEnd();

}