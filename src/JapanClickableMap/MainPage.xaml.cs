using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Shapes;

namespace JapanClickableMap
{
	public partial class MainPage : UserControl
    {
        #region init params (url) key

        private const string INIT_PARAM_HOKKAIDO_URL = "hokkaido_url";
        private const string INIT_PARAM_AOMORI_URL = "aomori_url";
        private const string INIT_PARAM_IWATE_URL = "iwate_url";
        private const string INIT_PARAM_MIYAGI_URL = "miyagi_url";
        private const string INIT_PARAM_AKITA_URL = "akita_url";
        private const string INIT_PARAM_YAMAGATA_URL = "yamagata_url";
        private const string INIT_PARAM_FUKUSHIMA_URL = "fukushima_url";
        private const string INIT_PARAM_IBARAKI_URL = "ibaraki_url";
        private const string INIT_PARAM_TOCHIGI_URL = "tochigi_url";
        private const string INIT_PARAM_GUNMA_URL = "gunma_url";
        private const string INIT_PARAM_SAITAMA_URL = "saitama_url";
        private const string INIT_PARAM_CHIBA_URL = "chiba_url";
        private const string INIT_PARAM_TOKYO_URL = "tokyo_url";
        private const string INIT_PARAM_KANAGAWA_URL = "kanagawa_url";
        private const string INIT_PARAM_NIIGATA_URL = "niigata_url";
        private const string INIT_PARAM_TOYAMA_URL = "toyama_url";
        private const string INIT_PARAM_ISHIKAWA_URL = "ishikawa_url";
        private const string INIT_PARAM_FUKUI_URL = "fukui_url";
        private const string INIT_PARAM_YAMANASHI_URL = "yamanashi_url";
        private const string INIT_PARAM_NAGANO_URL = "nagano_url";
        private const string INIT_PARAM_GIFU_URL = "gifu_url";
        private const string INIT_PARAM_SHIZUOKA_URL = "shizuoka_url";
        private const string INIT_PARAM_AICHI_URL = "aichi_url";
        private const string INIT_PARAM_MIE_URL = "mie_url";
        private const string INIT_PARAM_SHIGA_URL = "shiga_url";
        private const string INIT_PARAM_KYOTO_URL = "kyoto_url";
        private const string INIT_PARAM_OSAKA_URL = "osaka_url";
        private const string INIT_PARAM_HYOGO_URL = "hyogo_url";
        private const string INIT_PARAM_NARA_URL = "nara_url";
        private const string INIT_PARAM_WAKAYAMA_URL = "wakayama_url";
        private const string INIT_PARAM_TOTTORI_URL = "tottori_url";
        private const string INIT_PARAM_SHIMANE_URL = "shimane_url";
        private const string INIT_PARAM_OKAYAMA_URL = "okayama_url";
        private const string INIT_PARAM_HIROSHIMA_URL = "hiroshima_url";
        private const string INIT_PARAM_YAMAGUCHI_URL = "yamaguchi_url";
        private const string INIT_PARAM_TOKUSHIMA_URL = "tokushima_url";
        private const string INIT_PARAM_KAGAWA_URL = "kagawa_url";
        private const string INIT_PARAM_EHIME_URL = "ehime_url";
        private const string INIT_PARAM_KOCHI_URL = "kochi_url";
        private const string INIT_PARAM_FUKUOKA_URL = "fukuoka_url";
        private const string INIT_PARAM_SAGA_URL = "saga_url";
        private const string INIT_PARAM_NAGASAKI_URL = "nagasaki_url";
        private const string INIT_PARAM_KUMAMOTO_URL = "kumamoto_url";
        private const string INIT_PARAM_OITA_URL = "oita_url";
        private const string INIT_PARAM_MIYAZAKI_URL = "miyazaki_url";
        private const string INIT_PARAM_KAGOSHIMA_URL = "kagoshima_url";
        private const string INIT_PARAM_OKINAWA_URL = "okinawa_url";

        #endregion

        #region init params (tooltip) key

        private const string INIT_PARAM_HOKKAIDO_TOOLTIP = "hokkaido_tooltip";
        private const string INIT_PARAM_AOMORI_TOOLTIP = "aomori_tooltip";
        private const string INIT_PARAM_IWATE_TOOLTIP = "iwate_tooltip";
        private const string INIT_PARAM_MIYAGI_TOOLTIP = "miyagi_tooltip";
        private const string INIT_PARAM_AKITA_TOOLTIP = "akita_tooltip";
        private const string INIT_PARAM_YAMAGATA_TOOLTIP = "yamagata_tooltip";
        private const string INIT_PARAM_FUKUSHIMA_TOOLTIP = "fukushima_tooltip";
        private const string INIT_PARAM_IBARAKI_TOOLTIP = "ibaraki_tooltip";
        private const string INIT_PARAM_TOCHIGI_TOOLTIP = "tochigi_tooltip";
        private const string INIT_PARAM_GUNMA_TOOLTIP = "gunma_tooltip";
        private const string INIT_PARAM_SAITAMA_TOOLTIP = "saitama_tooltip";
        private const string INIT_PARAM_CHIBA_TOOLTIP = "chiba_tooltip";
        private const string INIT_PARAM_TOKYO_TOOLTIP = "tokyo_tooltip";
        private const string INIT_PARAM_KANAGAWA_TOOLTIP = "kanagawa_tooltip";
        private const string INIT_PARAM_NIIGATA_TOOLTIP = "niigata_tooltip";
        private const string INIT_PARAM_TOYAMA_TOOLTIP = "toyama_tooltip";
        private const string INIT_PARAM_ISHIKAWA_TOOLTIP = "ishikawa_tooltip";
        private const string INIT_PARAM_FUKUI_TOOLTIP = "fukui_tooltip";
        private const string INIT_PARAM_YAMANASHI_TOOLTIP = "yamanashi_tooltip";
        private const string INIT_PARAM_NAGANO_TOOLTIP = "nagano_tooltip";
        private const string INIT_PARAM_GIFU_TOOLTIP = "gifu_tooltip";
        private const string INIT_PARAM_SHIZUOKA_TOOLTIP = "shizuoka_tooltip";
        private const string INIT_PARAM_AICHI_TOOLTIP = "aichi_tooltip";
        private const string INIT_PARAM_MIE_TOOLTIP = "mie_tooltip";
        private const string INIT_PARAM_SHIGA_TOOLTIP = "shiga_tooltip";
        private const string INIT_PARAM_KYOTO_TOOLTIP = "kyoto_tooltip";
        private const string INIT_PARAM_OSAKA_TOOLTIP = "osaka_tooltip";
        private const string INIT_PARAM_HYOGO_TOOLTIP = "hyogo_tooltip";
        private const string INIT_PARAM_NARA_TOOLTIP = "nara_tooltip";
        private const string INIT_PARAM_WAKAYAMA_TOOLTIP = "wakayama_tooltip";
        private const string INIT_PARAM_TOTTORI_TOOLTIP = "tottori_tooltip";
        private const string INIT_PARAM_SHIMANE_TOOLTIP = "shimane_tooltip";
        private const string INIT_PARAM_OKAYAMA_TOOLTIP = "okayama_tooltip";
        private const string INIT_PARAM_HIROSHIMA_TOOLTIP = "hiroshima_tooltip";
        private const string INIT_PARAM_YAMAGUCHI_TOOLTIP = "yamaguchi_tooltip";
        private const string INIT_PARAM_TOKUSHIMA_TOOLTIP = "tokushima_tooltip";
        private const string INIT_PARAM_KAGAWA_TOOLTIP = "kagawa_tooltip";
        private const string INIT_PARAM_EHIME_TOOLTIP = "ehime_tooltip";
        private const string INIT_PARAM_KOCHI_TOOLTIP = "kochi_tooltip";
        private const string INIT_PARAM_FUKUOKA_TOOLTIP = "fukuoka_tooltip";
        private const string INIT_PARAM_SAGA_TOOLTIP = "saga_tooltip";
        private const string INIT_PARAM_NAGASAKI_TOOLTIP = "nagasaki_tooltip";
        private const string INIT_PARAM_KUMAMOTO_TOOLTIP = "kumamoto_tooltip";
        private const string INIT_PARAM_OITA_TOOLTIP = "oita_tooltip";
        private const string INIT_PARAM_MIYAZAKI_TOOLTIP = "miyazaki_tooltip";
        private const string INIT_PARAM_KAGOSHIMA_TOOLTIP = "kagoshima_tooltip";
        private const string INIT_PARAM_OKINAWA_TOOLTIP = "okinawa_tooltip";

        #endregion

        #region init params (other) key

        private const string INIT_PARAM_TARGET = "target";

        #endregion

        private IDictionary<string, string> _initParams = null;

        public MainPage(IDictionary<string, string> initParams)
		{
			InitializeComponent();
            this._initParams = initParams;
		}

        private void LayoutRoot_Loaded(object sender, RoutedEventArgs e)
        {
            #region set url

            if (this._initParams.ContainsKey(INIT_PARAM_HOKKAIDO_URL))
            {
                this.Hokkaido.Tag = this._initParams[INIT_PARAM_HOKKAIDO_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_AOMORI_URL))
            {
                this.Aomori.Tag = this._initParams[INIT_PARAM_AOMORI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_AKITA_URL))
            {
                this.Akita.Tag = this._initParams[INIT_PARAM_AKITA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_IWATE_URL))
            {
                this.Iwate.Tag = this._initParams[INIT_PARAM_IWATE_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_YAMAGATA_URL))
            {
                this.Yamagata.Tag = this._initParams[INIT_PARAM_YAMAGATA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_MIYAGI_URL))
            {
                this.Miyagi.Tag = this._initParams[INIT_PARAM_MIYAGI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_FUKUSHIMA_URL))
            {
                this.Fukushima.Tag = this._initParams[INIT_PARAM_FUKUSHIMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NIIGATA_URL))
            {
                this.Niigata.Tag = this._initParams[INIT_PARAM_NIIGATA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_IBARAKI_URL))
            {
                this.Ibaraki.Tag = this._initParams[INIT_PARAM_IBARAKI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOCHIGI_URL))
            {
                this.Tochigi.Tag = this._initParams[INIT_PARAM_TOCHIGI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_GUNMA_URL))
            {
                this.Gunma.Tag = this._initParams[INIT_PARAM_GUNMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_CHIBA_URL))
            {
                this.Chiba.Tag = this._initParams[INIT_PARAM_CHIBA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SAITAMA_URL))
            {
                this.Saitama.Tag = this._initParams[INIT_PARAM_SAITAMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOKYO_URL))
            {
                this.Tokyo.Tag = this._initParams[INIT_PARAM_TOKYO_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KANAGAWA_URL))
            {
                this.Kanagawa.Tag = this._initParams[INIT_PARAM_KANAGAWA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_YAMANASHI_URL))
            {
                this.Yamanashi.Tag = this._initParams[INIT_PARAM_YAMANASHI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SHIZUOKA_URL))
            {
                this.Shizuoka.Tag = this._initParams[INIT_PARAM_SHIZUOKA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_AICHI_URL))
            {
                this.Aichi.Tag = this._initParams[INIT_PARAM_AICHI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NAGANO_URL))
            {
                this.Nagano.Tag = this._initParams[INIT_PARAM_NAGANO_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOYAMA_URL))
            {
                this.Toyama.Tag = this._initParams[INIT_PARAM_TOYAMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_GIFU_URL))
            {
                this.Gifu.Tag = this._initParams[INIT_PARAM_GIFU_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_ISHIKAWA_URL))
            {
                this.Ishikawa.Tag = this._initParams[INIT_PARAM_ISHIKAWA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_FUKUI_URL))
            {
                this.Fukui.Tag = this._initParams[INIT_PARAM_FUKUI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SHIGA_URL))
            {
                this.Shiga.Tag = this._initParams[INIT_PARAM_SHIGA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_MIE_URL))
            {
                this.Mie.Tag = this._initParams[INIT_PARAM_MIE_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KYOTO_URL))
            {
                this.Kyoto.Tag = this._initParams[INIT_PARAM_KYOTO_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NARA_URL))
            {
                this.Nara.Tag = this._initParams[INIT_PARAM_NARA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_WAKAYAMA_URL))
            {
                this.Wakayama.Tag = this._initParams[INIT_PARAM_WAKAYAMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OSAKA_URL))
            {
                this.Osaka.Tag = this._initParams[INIT_PARAM_OSAKA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_HYOGO_URL))
            {
                this.Hyogo.Tag = this._initParams[INIT_PARAM_HYOGO_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOTTORI_URL))
            {
                this.Tottori.Tag = this._initParams[INIT_PARAM_TOTTORI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OKAYAMA_URL))
            {
                this.Okayama.Tag = this._initParams[INIT_PARAM_OKAYAMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_HIROSHIMA_URL))
            {
                this.Hiroshima.Tag = this._initParams[INIT_PARAM_HIROSHIMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SHIMANE_URL))
            {
                this.Shimane.Tag = this._initParams[INIT_PARAM_SHIMANE_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_YAMAGUCHI_URL))
            {
                this.Yamaguchi.Tag = this._initParams[INIT_PARAM_YAMAGUCHI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOKUSHIMA_URL))
            {
                this.Tokushima.Tag = this._initParams[INIT_PARAM_TOKUSHIMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KAGAWA_URL))
            {
                this.Kagawa.Tag = this._initParams[INIT_PARAM_KAGAWA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KOCHI_URL))
            {
                this.Kochi.Tag = this._initParams[INIT_PARAM_KOCHI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_EHIME_URL))
            {
                this.Ehime.Tag = this._initParams[INIT_PARAM_EHIME_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_FUKUOKA_URL))
            {
                this.Fukuoka.Tag = this._initParams[INIT_PARAM_FUKUOKA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OITA_URL))
            {
                this.Oita.Tag = this._initParams[INIT_PARAM_OITA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KUMAMOTO_URL))
            {
                this.Kumamoto.Tag = this._initParams[INIT_PARAM_KUMAMOTO_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SAGA_URL))
            {
                this.Saga.Tag = this._initParams[INIT_PARAM_SAGA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NAGASAKI_URL))
            {
                this.Nagasaki.Tag = this._initParams[INIT_PARAM_NAGASAKI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_MIYAZAKI_URL))
            {
                this.Miyazaki.Tag = this._initParams[INIT_PARAM_MIYAZAKI_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KAGOSHIMA_URL))
            {
                this.Kagoshima.Tag = this._initParams[INIT_PARAM_KAGOSHIMA_URL];
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OKINAWA_URL))
            {
                this.Okinawa.Tag = this._initParams[INIT_PARAM_OKINAWA_URL];
            }

            #endregion

            #region set tooltip

            if (this._initParams.ContainsKey(INIT_PARAM_HOKKAIDO_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Hokkaido, this._initParams[INIT_PARAM_HOKKAIDO_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_AOMORI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Aomori, this._initParams[INIT_PARAM_AOMORI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_AKITA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Akita, this._initParams[INIT_PARAM_AKITA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_IWATE_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Iwate, this._initParams[INIT_PARAM_IWATE_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_YAMAGATA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Yamagata, this._initParams[INIT_PARAM_YAMAGATA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_MIYAGI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Miyagi, this._initParams[INIT_PARAM_MIYAGI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_FUKUSHIMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Fukushima, this._initParams[INIT_PARAM_FUKUSHIMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NIIGATA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Niigata, this._initParams[INIT_PARAM_NIIGATA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_IBARAKI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Ibaraki, this._initParams[INIT_PARAM_IBARAKI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOCHIGI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Tochigi, this._initParams[INIT_PARAM_TOCHIGI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_GUNMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Gunma, this._initParams[INIT_PARAM_GUNMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_CHIBA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Chiba, this._initParams[INIT_PARAM_CHIBA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SAITAMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Saitama, this._initParams[INIT_PARAM_SAITAMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOKYO_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Tokyo, this._initParams[INIT_PARAM_TOKYO_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KANAGAWA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Kanagawa, this._initParams[INIT_PARAM_KANAGAWA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_YAMANASHI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Yamanashi, this._initParams[INIT_PARAM_YAMANASHI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SHIZUOKA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Shizuoka, this._initParams[INIT_PARAM_SHIZUOKA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_AICHI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Aichi, this._initParams[INIT_PARAM_AICHI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NAGANO_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Nagano, this._initParams[INIT_PARAM_NAGANO_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOYAMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Toyama, this._initParams[INIT_PARAM_TOYAMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_GIFU_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Gifu, this._initParams[INIT_PARAM_GIFU_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_ISHIKAWA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Ishikawa, this._initParams[INIT_PARAM_ISHIKAWA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_FUKUI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Fukui, this._initParams[INIT_PARAM_FUKUI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SHIGA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Shiga, this._initParams[INIT_PARAM_SHIGA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_MIE_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Mie, this._initParams[INIT_PARAM_MIE_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KYOTO_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Kyoto, this._initParams[INIT_PARAM_KYOTO_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NARA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Nara, this._initParams[INIT_PARAM_NARA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_WAKAYAMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Wakayama, this._initParams[INIT_PARAM_WAKAYAMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OSAKA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Osaka, this._initParams[INIT_PARAM_OSAKA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_HYOGO_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Hyogo, this._initParams[INIT_PARAM_HYOGO_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOTTORI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Tottori, this._initParams[INIT_PARAM_TOTTORI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OKAYAMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Okayama, this._initParams[INIT_PARAM_OKAYAMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_HIROSHIMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Hiroshima, this._initParams[INIT_PARAM_HIROSHIMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SHIMANE_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Shimane, this._initParams[INIT_PARAM_SHIMANE_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_YAMAGUCHI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Yamaguchi, this._initParams[INIT_PARAM_YAMAGUCHI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_TOKUSHIMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Tokushima, this._initParams[INIT_PARAM_TOKUSHIMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KAGAWA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Kagawa, this._initParams[INIT_PARAM_KAGAWA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KOCHI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Kochi, this._initParams[INIT_PARAM_KOCHI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_EHIME_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Ehime, this._initParams[INIT_PARAM_EHIME_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_FUKUOKA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Fukuoka, this._initParams[INIT_PARAM_FUKUOKA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OITA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Oita, this._initParams[INIT_PARAM_OITA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KUMAMOTO_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Kumamoto, this._initParams[INIT_PARAM_KUMAMOTO_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_SAGA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Saga, this._initParams[INIT_PARAM_SAGA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_NAGASAKI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Nagasaki, this._initParams[INIT_PARAM_NAGASAKI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_MIYAZAKI_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Miyazaki, this._initParams[INIT_PARAM_MIYAZAKI_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_KAGOSHIMA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Kagoshima, this._initParams[INIT_PARAM_KAGOSHIMA_TOOLTIP]);
            }
            if (this._initParams.ContainsKey(INIT_PARAM_OKINAWA_TOOLTIP))
            {
                ToolTipService.SetToolTip(this.Okinawa, this._initParams[INIT_PARAM_OKINAWA_TOOLTIP]);
            }

            #endregion
        }

        private void Pref_MouseEnter(object sender, MouseEventArgs e)
        {
            ((Path)sender).Opacity = 1.0;

            if (((Path)sender) == this.Niigata)
            {
                this.Sado.Opacity = 1.0;
            }
            else if (((Path)sender) == this.Sado)
            {
                this.Niigata.Opacity = 1.0;
            }
            else if (((Path)sender) == this.Hyogo)
            {
                this.Awaji.Opacity = 1.0;
            }
            else if (((Path)sender) == this.Awaji)
            {
                this.Hyogo.Opacity = 1.0;
            }

            if (((Path)sender).Tag != null)
            {
                ((Path)sender).Cursor = Cursors.Hand;
            }
        }

        private void Pref_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Path)sender).Opacity = 0.0;

            if (((Path)sender) == this.Niigata)
            {
                this.Sado.Opacity = 0.0;
            }
            else if (((Path)sender) == this.Sado)
            {
                this.Niigata.Opacity = 0.0;
            }
            else if (((Path)sender) == this.Hyogo)
            {
                this.Awaji.Opacity = 0.0;
            }
            else if (((Path)sender) == this.Awaji)
            {
                this.Hyogo.Opacity = 0.0;
            }
        }

        private void Pref_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Path pref = (Path)sender;

            if (((Path)sender) == this.Sado)
            {
                pref = this.Niigata;
            }
            else if (((Path)sender) == this.Awaji)
            {
                pref = this.Hyogo;
            }

            Uri u;
            if (pref.Tag != null
                && Uri.TryCreate(pref.Tag.ToString(), UriKind.RelativeOrAbsolute, out u))
            {
                if (this._initParams.ContainsKey(INIT_PARAM_TARGET))
                {
                    HtmlPage.Window.Navigate(u, INIT_PARAM_TARGET);
                }
                else
                {
                    HtmlPage.Window.Navigate(u);
                }
            }
        }

        #region set url

        [ScriptableMember()]
        public void SetHokkaidoUrl(string url)
        {
            this.Hokkaido.Tag = url;
        }

        [ScriptableMember()]
        public void SetAomoriUrl(string url)
        {
            this.Aomori.Tag = url;
        }

        [ScriptableMember()]
        public void SetAkitaUrl(string url)
        {
            this.Akita.Tag = url;
        }

        [ScriptableMember()]
        public void SetIwateUrl(string url)
        {
            this.Iwate.Tag = url;
        }

        [ScriptableMember()]
        public void SetYamagataUrl(string url)
        {
            this.Yamagata.Tag = url;
        }

        [ScriptableMember()]
        public void SetMiyagiUrl(string url)
        {
            this.Miyagi.Tag = url;
        }

        [ScriptableMember()]
        public void SetFukushimaUrl(string url)
        {
            this.Fukushima.Tag = url;
        }

        [ScriptableMember()]
        public void SetNiigataUrl(string url)
        {
            this.Niigata.Tag = url;
        }

        [ScriptableMember()]
        public void SetIbarakiUrl(string url)
        {
            this.Ibaraki.Tag = url;
        }

        [ScriptableMember()]
        public void SetTochigiUrl(string url)
        {
            this.Tochigi.Tag = url;
        }

        [ScriptableMember()]
        public void SetGunmaUrl(string url)
        {
            this.Gunma.Tag = url;
        }

        [ScriptableMember()]
        public void SetChibaUrl(string url)
        {
            this.Chiba.Tag = url;
        }

        [ScriptableMember()]
        public void SetSaitamaUrl(string url)
        {
            this.Saitama.Tag = url;
        }

        [ScriptableMember()]
        public void SetTokyoUrl(string url)
        {
            this.Tokyo.Tag = url;
        }

        [ScriptableMember()]
        public void SetKanagawaUrl(string url)
        {
            this.Kanagawa.Tag = url;
        }

        [ScriptableMember()]
        public void SetYamanashiUrl(string url)
        {
            this.Yamanashi.Tag = url;
        }

        [ScriptableMember()]
        public void SetShizuokaUrl(string url)
        {
            this.Shizuoka.Tag = url;
        }

        [ScriptableMember()]
        public void SetAichiUrl(string url)
        {
            this.Aichi.Tag = url;
        }

        [ScriptableMember()]
        public void SetNaganoUrl(string url)
        {
            this.Nagano.Tag = url;
        }

        [ScriptableMember()]
        public void SetToyamaUrl(string url)
        {
            this.Toyama.Tag = url;
        }

        [ScriptableMember()]
        public void SetGifuUrl(string url)
        {
            this.Gifu.Tag = url;
        }

        [ScriptableMember()]
        public void SetIshikawaUrl(string url)
        {
            this.Ishikawa.Tag = url;
        }

        [ScriptableMember()]
        public void SetFukuiUrl(string url)
        {
            this.Fukui.Tag = url;
        }

        [ScriptableMember()]
        public void SetShigaUrl(string url)
        {
            this.Shiga.Tag = url;
        }

        [ScriptableMember()]
        public void SetMieUrl(string url)
        {
            this.Mie.Tag = url;
        }

        [ScriptableMember()]
        public void SetKyotoUrl(string url)
        {
            this.Kyoto.Tag = url;
        }

        [ScriptableMember()]
        public void SetNaraUrl(string url)
        {
            this.Nara.Tag = url;
        }

        [ScriptableMember()]
        public void SetWakayamaUrl(string url)
        {
            this.Wakayama.Tag = url;
        }

        [ScriptableMember()]
        public void SetOsakaUrl(string url)
        {
            this.Osaka.Tag = url;
        }

        [ScriptableMember()]
        public void SetHyogoUrl(string url)
        {
            this.Hyogo.Tag = url;
        }

        [ScriptableMember()]
        public void SetTottoriUrl(string url)
        {
            this.Tottori.Tag = url;
        }

        [ScriptableMember()]
        public void SetOkayamaUrl(string url)
        {
            this.Okayama.Tag = url;
        }

        [ScriptableMember()]
        public void SetHiroshimaUrl(string url)
        {
            this.Hiroshima.Tag = url;
        }

        [ScriptableMember()]
        public void SetShimaneUrl(string url)
        {
            this.Shimane.Tag = url;
        }

        [ScriptableMember()]
        public void SetYamaguchiUrl(string url)
        {
            this.Yamaguchi.Tag = url;
        }

        [ScriptableMember()]
        public void SetTokushimaUrl(string url)
        {
            this.Tokushima.Tag = url;
        }

        [ScriptableMember()]
        public void SetKagawaUrl(string url)
        {
            this.Kagawa.Tag = url;
        }

        [ScriptableMember()]
        public void SetKochiUrl(string url)
        {
            this.Kochi.Tag = url;
        }

        [ScriptableMember()]
        public void SetEhimeUrl(string url)
        {
            this.Ehime.Tag = url;
        }

        [ScriptableMember()]
        public void SetFukuokaUrl(string url)
        {
            this.Fukuoka.Tag = url;
        }

        [ScriptableMember()]
        public void SetOitaUrl(string url)
        {
            this.Oita.Tag = url;
        }

        [ScriptableMember()]
        public void SetKumamotoUrl(string url)
        {
            this.Kumamoto.Tag = url;
        }

        [ScriptableMember()]
        public void SetSagaUrl(string url)
        {
            this.Saga.Tag = url;
        }

        [ScriptableMember()]
        public void SetNagasakiUrl(string url)
        {
            this.Nagasaki.Tag = url;
        }

        [ScriptableMember()]
        public void SetMiyazakiUrl(string url)
        {
            this.Miyazaki.Tag = url;
        }

        [ScriptableMember()]
        public void SetKagoshimaUrl(string url)
        {
            this.Kagoshima.Tag = url;
        }

        [ScriptableMember()]
        public void SetOkinawaUrl(string url)
        {
            this.Okinawa.Tag = url;
        }

        #endregion

        #region set tooltip

        [ScriptableMember()]
        public void SetHokkaidoToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Hokkaido, toolTip);
        }

        [ScriptableMember()]
        public void SetAomoriToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Aomori, toolTip);
        }

        [ScriptableMember()]
        public void SetAkitaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Akita, toolTip);
        }

        [ScriptableMember()]
        public void SetIwateToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Iwate, toolTip);
        }

        [ScriptableMember()]
        public void SetYamagataToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Yamagata, toolTip);
        }

        [ScriptableMember()]
        public void SetMiyagiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Miyagi, toolTip);
        }

        [ScriptableMember()]
        public void SetFukushimaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Fukushima, toolTip);
        }

        [ScriptableMember()]
        public void SetNiigataToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Niigata, toolTip);
        }

        [ScriptableMember()]
        public void SetIbarakiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Ibaraki, toolTip);
        }

        [ScriptableMember()]
        public void SetTochigiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Tochigi, toolTip);
        }

        [ScriptableMember()]
        public void SetGunmaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Gunma, toolTip);
        }

        [ScriptableMember()]
        public void SetChibaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Chiba, toolTip);
        }

        [ScriptableMember()]
        public void SetSaitamaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Saitama, toolTip);
        }

        [ScriptableMember()]
        public void SetTokyoToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Tokyo, toolTip);
        }

        [ScriptableMember()]
        public void SetKanagawaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Kanagawa, toolTip);
        }

        [ScriptableMember()]
        public void SetYamanashiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Yamanashi, toolTip);
        }

        [ScriptableMember()]
        public void SetShizuokaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Shizuoka, toolTip);
        }

        [ScriptableMember()]
        public void SetAichiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Aichi, toolTip);
        }

        [ScriptableMember()]
        public void SetNaganoToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Nagano, toolTip);
        }

        [ScriptableMember()]
        public void SetToyamaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Toyama, toolTip);
        }

        [ScriptableMember()]
        public void SetGifuToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Gifu, toolTip);
        }

        [ScriptableMember()]
        public void SetIshikawaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Ishikawa, toolTip);
        }

        [ScriptableMember()]
        public void SetFukuiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Fukui, toolTip);
        }

        [ScriptableMember()]
        public void SetShigaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Shiga, toolTip);
        }

        [ScriptableMember()]
        public void SetMieToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Mie, toolTip);
        }

        [ScriptableMember()]
        public void SetKyotoToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Kyoto, toolTip);
        }

        [ScriptableMember()]
        public void SetNaraToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Nara, toolTip);
        }

        [ScriptableMember()]
        public void SetWakayamaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Wakayama, toolTip);
        }

        [ScriptableMember()]
        public void SetOsakaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Osaka, toolTip);
        }

        [ScriptableMember()]
        public void SetHyogoToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Hyogo, toolTip);
        }

        [ScriptableMember()]
        public void SetTottoriToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Tottori, toolTip);
        }

        [ScriptableMember()]
        public void SetOkayamaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Okayama, toolTip);
        }

        [ScriptableMember()]
        public void SetHiroshimaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Hiroshima, toolTip);
        }

        [ScriptableMember()]
        public void SetShimaneToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Shimane, toolTip);
        }

        [ScriptableMember()]
        public void SetYamaguchiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Yamaguchi, toolTip);
        }

        [ScriptableMember()]
        public void SetTokushimaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Tokushima, toolTip);
        }

        [ScriptableMember()]
        public void SetKagawaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Kagawa, toolTip);
        }

        [ScriptableMember()]
        public void SetKochiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Kochi, toolTip);
        }

        [ScriptableMember()]
        public void SetEhimeToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Ehime, toolTip);
        }

        [ScriptableMember()]
        public void SetFukuokaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Fukuoka, toolTip);
        }

        [ScriptableMember()]
        public void SetOitaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Oita, toolTip);
        }

        [ScriptableMember()]
        public void SetKumamotoToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Kumamoto, toolTip);
        }

        [ScriptableMember()]
        public void SetSagaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Saga, toolTip);
        }

        [ScriptableMember()]
        public void SetNagasakiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Nagasaki, toolTip);
        }

        [ScriptableMember()]
        public void SetMiyazakiToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Miyazaki, toolTip);
        }

        [ScriptableMember()]
        public void SetKagoshimaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Kagoshima, toolTip);
        }

        [ScriptableMember()]
        public void SetOkinawaToolTip(string toolTip)
        {
            ToolTipService.SetToolTip(this.Okinawa, toolTip);
        }

        #endregion
    }
}