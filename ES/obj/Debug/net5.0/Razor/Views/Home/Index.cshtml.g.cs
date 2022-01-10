#pragma checksum "D:\Thực tập\asp\ES_LearnASP\LearnASP\ES\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "080b2e8877f33c0396bbbaf406651ba235b28424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Thực tập\asp\ES_LearnASP\LearnASP\ES\Views\_ViewImports.cshtml"
using ES;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Thực tập\asp\ES_LearnASP\LearnASP\ES\Views\_ViewImports.cshtml"
using ES.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"080b2e8877f33c0396bbbaf406651ba235b28424", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cb71dcccc22148844147317cf4723535eaa3d16", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Thực tập\asp\ES_LearnASP\LearnASP\ES\Views\Home\Index.cshtml"
  
    ViewBag.Title = "Trang chủ";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script src=""https://code.highcharts.com/highcharts.js""></script>
<script src=""https://code.highcharts.com/modules/series-label.js""></script>
<script src=""https://code.highcharts.com/modules/exporting.js""></script>
<script src=""https://code.highcharts.com/modules/export-data.js""></script>

<figure class=""highcharts-figure"">
    <div id=""container""></div>
</figure>

<script>
    function HChart() {
        $.getJSON(""/Home/GetData"", function (data) {
            //debugger;
            var MatTroi = []
            var Gio = []
            var SinhKhoi = []
            var Tong = []
            var ThoiGian = []

            for (var i = 0; i < data.length; i++) {
                MatTroi.push(data[i].matTroi_HienTai);
                Gio.push(data[i].gio_HienTai);
                SinhKhoi.push(data[i].sinhKhoi_HienTai);
                Tong.push(data[i].tong_HienTai);
                ThoiGian.push(data[i].thoiGian);
            }

            Highcharts.chart('container', {
       ");
            WriteLiteral(@"         chart: {
                    type: 'spline'
                },
                title: {
                    text: 'Năng lượng tái tạo'
                },
                /*subtitle: {
                    text: 'Source: WorldClimate.com'
                },*/
                xAxis: {
                    categories: ThoiGian
                },
                yAxis: {
                    title: {
                        text: 'Công suất hiện tại'
                    },
                    labels: {
                        formatter: function () {
                            return this.value + 'MW';
                        }
                    }
                },
                tooltip: {
                    crosshairs: true,
                    shared: true
                },
                plotOptions: {
                    spline: {
                        marker: {
                            radius: 4,
                            lineColor: '#666666',
            ");
            WriteLiteral(@"                lineWidth: 1
                        }
                    }
                },
                series: [{
                    name: 'Mặt trời',
                    data: MatTroi
                }, {
                    name: 'Gió',
                    data: Gio
                }, {
                    name: 'Sinh khối ',
                    data: SinhKhoi
                }, {
                    name: 'Tổng',
                    data: Tong
                }]
            });
        });
    }
    $(document).ready(HChart);
    setInterval(HChart,60000);
</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
