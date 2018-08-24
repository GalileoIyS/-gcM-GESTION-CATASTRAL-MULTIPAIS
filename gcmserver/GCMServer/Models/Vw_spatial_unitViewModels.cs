using System;
using System.Collections.Generic;

namespace AspNetCoreApplication.Models.vw_spatial_unit
{
    public class DetailViewModel
    {
        public GCMClases.cVW_SPATIAL_UNIT vw_spatial_unit { get; set; }
        public List<GCMClases.cVW_CROPS> vw_crops { get; set; }
        public List<GCMClases.cVW_BA_UNIT> vw_ba_unit { get; set; }
        public List<GCMClases.cVW_EXT_CUR_VALUATION> vw_ext_cur_valuation { get; set; }
        public List<GCMClases.cVW_EXT_CUR_TAXATION> vw_ext_cur_taxation { get; set; }
        public List<GCMClases.cVW_RIGHT> vw_right { get; set; }

        public DetailViewModel()
        {
            this.vw_spatial_unit = new GCMClases.cVW_SPATIAL_UNIT();
        }
        public DetailViewModel(string id) : this()
        {
            this.vw_spatial_unit.oid = id;
            if (this.vw_spatial_unit.bConsultar())
            {
                using (GCMClases.cVW_CROPS objCrop = new GCMClases.cVW_CROPS())
                {
                    int totalrecords = 0;
                    objCrop.local_id = this.vw_spatial_unit.local_id;
                    this.vw_crops = objCrop.ObtenerListaDatos(ref totalrecords, String.Empty, 0, 0, string.Empty);
                }
                using (GCMClases.cVW_BA_UNIT objBaUnit = new GCMClases.cVW_BA_UNIT())
                {
                    int totalrecords = 0;
                    objBaUnit.local_id = this.vw_spatial_unit.local_id;
                    this.vw_ba_unit = objBaUnit.ObtenerListaDatos(ref totalrecords, String.Empty, 0, 0, string.Empty);
                }
                using (GCMClases.cVW_EXT_CUR_VALUATION objValuation = new GCMClases.cVW_EXT_CUR_VALUATION())
                {
                    int totalrecords = 0;
                    objValuation.local_id = this.vw_spatial_unit.local_id;
                    this.vw_ext_cur_valuation = objValuation.ObtenerListaDatos(ref totalrecords, String.Empty, 0, 0, string.Empty);
                }
                using (GCMClases.cVW_EXT_CUR_TAXATION objTaxation = new GCMClases.cVW_EXT_CUR_TAXATION())
                {
                    int totalrecords = 0;
                    objTaxation.local_id = this.vw_spatial_unit.local_id;
                    this.vw_ext_cur_taxation = objTaxation.ObtenerListaDatos(ref totalrecords, String.Empty, 0, 0, string.Empty);
                }
                using (GCMClases.cVW_RIGHT objRight= new GCMClases.cVW_RIGHT())
                {
                    int totalrecords = 0;
                    objRight.local_id = this.vw_spatial_unit.local_id;
                    this.vw_right = objRight.ObtenerListaDatos(ref totalrecords, String.Empty, 0, 0, string.Empty);
                }
            };
        }
    }

    public class GetFeatureInfo
    {
        public string address { get; set; }

        public GetFeatureInfo()
        {
            this.address = string.Empty;
        }
    }
}
