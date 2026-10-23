using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace FrankGame
{
    public class PromptPanel : MonoBehaviour
    {
        public Text TitleText;
        public Text ContentText;
        public Button Confirm1Btn;
        public Button Confirm2Btn;
        public Button CancelBtn;
        public Text Confirm1BtnText;
        public Text Confirm2BtnText;
        public Text CancelBtnText;

        public void ShowTwoButton(string _title, string _content, string _confirm, string _cancel, System.Action _onConfirmFunc, System.Action _onCancelFunc)
        {
            this.Confirm1Btn.gameObject.SetActive(false);
            this.Confirm2Btn.gameObject.SetActive(true);
            this.CancelBtn.gameObject.SetActive(true);

            this.TitleText.text = _title;
            this.ContentText.text = _content;
            this.Confirm2BtnText.text = _confirm;
            this.CancelBtnText.text = _cancel;

            this.Confirm2Btn.onClick.RemoveAllListeners();
            this.CancelBtn.onClick.RemoveAllListeners();

            this.Confirm2Btn.onClick.AddListener(() =>
            {
                _onConfirmFunc?.Invoke();
            });
            this.CancelBtn.onClick.AddListener(() =>
            {
                _onCancelFunc?.Invoke();
            });
        }

        public void ShowOneButton(string _title, string _content, string _confirm, System.Action _onConfirmFunc)
        {
            this.Confirm1Btn.gameObject.SetActive(true);
            this.Confirm2Btn.gameObject.SetActive(false);
            this.CancelBtn.gameObject.SetActive(false);

            this.TitleText.text = _title;
            this.ContentText.text = _content;
            this.Confirm1BtnText.text = _confirm;

            this.Confirm1Btn.onClick.RemoveAllListeners();

            this.Confirm1Btn.onClick.AddListener(() =>
            {
                _onConfirmFunc?.Invoke();
            });
        }
    }
}