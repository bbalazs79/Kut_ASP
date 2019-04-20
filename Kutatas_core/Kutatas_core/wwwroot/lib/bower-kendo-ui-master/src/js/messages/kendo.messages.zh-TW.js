/** 
 * Copyright 2019 Progress Software Corporation and/or one of its subsidiaries or affiliates. All rights reserved.                                                                                      
 *                                                                                                                                                                                                      
 * Licensed under the Apache License, Version 2.0 (the "License");                                                                                                                                      
 * you may not use this file except in compliance with the License.                                                                                                                                     
 * You may obtain a copy of the License at                                                                                                                                                              
 *                                                                                                                                                                                                      
 *     http://www.apache.org/licenses/LICENSE-2.0                                                                                                                                                       
 *                                                                                                                                                                                                      
 * Unless required by applicable law or agreed to in writing, software                                                                                                                                  
 * distributed under the License is distributed on an "AS IS" BASIS,                                                                                                                                    
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.                                                                                                                             
 * See the License for the specific language governing permissions and                                                                                                                                  
 * limitations under the License.                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       
                                                                                                                                                                                                       

*/

(function(f){
    if (typeof define === 'function' && define.amd) {
        define(["kendo.core"], f);
    } else {
        f();
    }
}(function(){
/* JS for All Kendo UI Components Traditional Chinese (zh-TW) Language Pack | Written by IKKI | 2018-02-22 */
(function ($, undefined) {

    /* FlatColorPicker messages */
    if (kendo.ui.FlatColorPicker) {
        kendo.ui.FlatColorPicker.prototype.options.messages =
            $.extend(true, kendo.ui.FlatColorPicker.prototype.options.messages,{
                "apply": "確定",
                "cancel": "取消",
                "noColor": "無顏色",
                "clearColor": "清除顏色",
                "previewInput": "顏色十六進位代碼"
            });
    }

    /* ColorPicker messages */
    if (kendo.ui.ColorPicker) {
        kendo.ui.ColorPicker.prototype.options.messages =
            $.extend(true, kendo.ui.ColorPicker.prototype.options.messages,{
                "apply": "確定",
                "cancel": "取消",
                "noColor": "無顏色",
                "clearColor": "清除顏色",
                "previewInput": "顏色十六進位代碼"
            });
    }

    /* ColumnMenu messages */
    if (kendo.ui.ColumnMenu) {
        kendo.ui.ColumnMenu.prototype.options.messages =
            $.extend(true, kendo.ui.ColumnMenu.prototype.options.messages,{
                "sortAscending": "昇冪排列",
                "sortDescending": "降冪排列",
                "filter": "篩選",
                "columns": "欄位列",
                "done": "完成",
                "settings": "列設置",
                "lock": "鎖定",
                "unlock": "解鎖"
            });
    }

    /* Editor messages */
    if (kendo.ui.Editor) {
        kendo.ui.Editor.prototype.options.messages =
            $.extend(true, kendo.ui.Editor.prototype.options.messages,{
                "bold": "粗體",
                "italic": "斜體",
                "underline": "底線",
                "strikethrough": "刪除線",
                "superscript": "上標",
                "subscript": "下標",
                "justifyCenter": "水準居中",
                "justifyLeft": "左對齊",
                "justifyRight": "右對齊",
                "justifyFull": "兩端對齊",
                "insertUnorderedList": "插入無序列表",
                "insertOrderedList": "插入有序列表",
                "indent": "增加縮進",
                "outdent": "減少縮進",
                "createLink": "插入連結",
                "unlink": "刪除連結",
                "insertImage": "插入圖片",
                "insertFile": "插入文件",
                "insertHtml": "插入HTML",
                "viewHtml": "原始程式碼編輯",
                "fontName": "請選擇字體",
                "fontNameInherit": "（預設字體）",
                "fontSize": "請選擇字型大小",
                "fontSizeInherit": "（默認字型大小）",
                "formatBlock": "格式",
                "formatting": "格式",
                "foreColor": "文字顏色",
                "backColor": "文字背景色",
                "style": "樣式",
                "emptyFolder": "資料夾為空",
                "editAreaTitle": "在可編輯區域可按 F10 跳轉工具列。",
                "uploadFile": "上傳文件",
                "overflowAnchor": "更多功能",
                "orderBy": "排序方式：",
                "orderBySize": "按大小排序",
                "orderByName": "按名稱排序",
                "invalidFileType": "你上傳的檔案格式 {0} 是無效的，支持的檔案類型為：{1}",
                "deleteFile": "你確定要刪除【{0}】這個檔嗎？",
                "overwriteFile": "當前資料夾已存在檔案名為【{0}】的檔，是否覆蓋？",
                "directoryNotFound": "資料夾未找到",
                "imageWebAddress": "圖片連結位址",
                "imageAltText": "圖片預留位置",
                "imageWidth": "圖片寬度（單位px）",
                "imageHeight": "圖片高度（單位px）",
                "fileWebAddress": "檔連結位址",
                "fileTitle": "文件標題",
                "linkWebAddress": "連結位址",
                "linkText": "連結文字",
                "linkToolTip": "連結提示",
                "linkOpenInNewWindow": "在新視窗中打開連結",
                "dialogUpdate": "更新",
                "dialogInsert": "插入",
                "dialogButtonSeparator": "或",
                "dialogOk": "確定",
                "dialogCancel": "取消",
                "cleanFormatting": "清除格式",
                "createTable": "創建表格",
                "createTableHint": "創建一個 {0} 行 {1} 列的表格",
                "addColumnLeft": "在左側插入列",
                "addColumnRight": "在右側插入列",
                "addRowAbove": "在上方插入行",
                "addRowBelow": "在下方插入行",
                "deleteRow": "刪除行",
                "deleteColumn": "刪除列",
                "tableWizard": "表格嚮導",
                "tableTab": "表格",
                "cellTab": "儲存格",
                "accessibilityTab": "可訪問性",
                "caption": "標題",
                "summary": "摘要",
                "width": "寬",
                "height": "高",
                "units": "單位",
                "cellSpacing": "儲存格間距",
                "cellPadding": "儲存格內邊距",
                "cellMargin": "單元格外邊距",
                "alignment": "對齊",
                "background": "背景色",
                "cssClass": "樣式表",
                "id": "ID",
                "border": "邊框",
                "borderStyle": "邊框樣式",
                "collapseBorders": "合併邊框",
                "wrapText": "文字換行",
                "associateCellsWithHeaders": "關聯表頭與儲存格",
                "alignLeft": "左對齊",
                "alignCenter": "居中對齊",
                "alignRight": "右對齊",
                "alignLeftTop": "左上對齊",
                "alignCenterTop": "中上對齊",
                "alignRightTop": "右上對齊",
                "alignLeftMiddle": "左中對齊",
                "alignCenterMiddle": "居中對齊",
                "alignRightMiddle": "右中對齊",
                "alignLeftBottom": "左下對齊",
                "alignCenterBottom": "中下對齊",
                "alignRightBottom": "右下對齊",
                "alignRemove": "移除對齊",
                "columns": "列",
                "rows": "行",
                "selectAllCells": "選擇所有儲存格",
                "exportAs": "匯出",
                "import": "導入"
            });
    }

    /* FileBrowser messages */
    if (kendo.ui.FileBrowser) {
        kendo.ui.FileBrowser.prototype.options.messages =
            $.extend(true, kendo.ui.FileBrowser.prototype.options.messages,{
                "uploadFile": "上傳文件",
                "orderBy": "排序方式",
                "orderByName": "按名稱排序",
                "orderBySize": "按大小排序",
                "directoryNotFound": "資料夾未找到",
                "emptyFolder": "資料夾為空",
                "deleteFile": "你確定要刪除【{0}】這個檔嗎？",
                "invalidFileType": "你上傳的檔案格式 {0} 是無效的，支持的檔案類型為：{1}",
                "overwriteFile": "當前資料夾已存在檔案名為【{0}】的檔，是否覆蓋？",
                "dropFilesHere": "將文件拖拽到此處上傳",
                "search": "搜索"
            });
    }

    /* FilterCell messages */
    if (kendo.ui.FilterCell) {
        kendo.ui.FilterCell.prototype.options.messages =
            $.extend(true, kendo.ui.FilterCell.prototype.options.messages,{
                "isTrue": "是",
                "isFalse": "否",
                "filter": "篩選",
                "clear": "清空",
                "operator": "運算子"
            });
    }

    /* FilterCell operators */
    if (kendo.ui.FilterCell) {
        kendo.ui.FilterCell.prototype.options.operators =
            $.extend(true, kendo.ui.FilterCell.prototype.options.operators,{
                "string": {
                    "eq": "等於",
                    "neq": "不等於",
                    "startswith": "開頭是",
                    "contains": "包含",
                    "doesnotcontain": "不含",
                    "endswith": "結尾是",
                    "isnull": "為空",
                    "isnotnull": "非空",
                    "isempty": "空字串",
                    "isnotempty": "非空字串",
                    "isnullorempty": "無值",
                    "isnotnullorempty": "有值"
                },
                "number": {
                    "eq": "等於",
                    "neq": "不等於",
                    "gte": "大於等於",
                    "gt": "大於",
                    "lte": "小於等於",
                    "lt": "小於",
                    "isnull": "為空",
                    "isnotnull": "非空"
                },
                "date": {
                    "eq": "等於",
                    "neq": "不等於",
                    "gte": "晚於等於",
                    "gt": "晚於",
                    "lte": "早於等於",
                    "lt": "早於",
                    "isnull": "為空",
                    "isnotnull": "非空"
                },
                "enums": {
                    "eq": "等於",
                    "neq": "不等於",
                    "isnull": "為空",
                    "isnotnull": "非空"
                }
            });
    }

    /* FilterMenu messages */
    if (kendo.ui.FilterMenu) {
        kendo.ui.FilterMenu.prototype.options.messages =
            $.extend(true, kendo.ui.FilterMenu.prototype.options.messages,{
                "info": "篩選條件：",
                "title": "篩選條件：",
                "isTrue": "是",
                "isFalse": "否",
                "filter": "篩選",
                "clear": "清空",
                "and": "並且",
                "or": "或者",
                "selectValue": "-= 請選擇 =-",
                "operator": "運算子",
                "value": "值",
                "additionalValue": "附加值",
                "additionalOperator": "附加運算",
                "logic": "篩選邏輯",
                "cancel": "取消"
            });
    }

    /* FilterMenu operator messages */
    if (kendo.ui.FilterMenu) {
        kendo.ui.FilterMenu.prototype.options.operators =
            $.extend(true, kendo.ui.FilterMenu.prototype.options.operators,{
                "string": {
                    "eq": "等於",
                    "neq": "不等於",
                    "startswith": "開頭是",
                    "contains": "包含",
                    "doesnotcontain": "不含",
                    "endswith": "結尾是",
                    "isnull": "為空",
                    "isnotnull": "非空",
                    "isempty": "空字串",
                    "isnotempty": "非空字串",
                    "isnullorempty": "無值",
                    "isnotnullorempty": "有值"
                },
                "number": {
                    "eq": "等於",
                    "neq": "不等於",
                    "gte": "大於等於",
                    "gt": "大於",
                    "lte": "小於等於",
                    "lt": "小於",
                    "isnull": "為空",
                    "isnotnull": "非空"
                },
                "date": {
                    "eq": "等於",
                    "neq": "不等於",
                    "gte": "晚於等於",
                    "gt": "晚於",
                    "lte": "早於等於",
                    "lt": "早於",
                    "isnull": "為空",
                    "isnotnull": "非空"
                },
                "enums": {
                    "eq": "等於",
                    "neq": "不等於",
                    "isnull": "為空",
                    "isnotnull": "非空"
                }
            });
    }

    /* FilterMultiCheck messages */
    if (kendo.ui.FilterMultiCheck) {
        kendo.ui.FilterMultiCheck.prototype.options.messages =
            $.extend(true, kendo.ui.FilterMultiCheck.prototype.options.messages,{
                "checkAll": "全選",
                "clear": "清空",
                "filter": "篩選",
                "search": "搜索",
                "cancel": "取消",
                "selectedItemsFormat": "已選擇 {0} 條資料"
            });
    }

    /* Gantt messages */
    if (kendo.ui.Gantt) {
        kendo.ui.Gantt.prototype.options.messages =
            $.extend(true, kendo.ui.Gantt.prototype.options.messages,{
                "actions": {
                    "addChild": "新增子任務",
                    "append": "新增任務",
                    "insertAfter": "插入到後面",
                    "insertBefore": "插入到前面",
                    "pdf": "匯出 PDF"
                },
                "cancel": "取消",
                "deleteDependencyWindowTitle": "刪除從屬任務",
                "deleteDependencyConfirmation": "你確定要刪除這項從屬任務嗎？",
                "deleteTaskWindowTitle": "刪除任務",
                "deleteTaskConfirmation": "你確定要刪除這項任務嗎？",
                "destroy": "刪除",
                "editor": {
                    "assingButton": "資源配置",
                    "editorTitle": "編輯任務",
                    "end": "結束時間",
                    "percentComplete": "完成進度",
                    "resources": "資源",
                    "resourcesEditorTitle": "資源編輯",
                    "resourcesHeader": "資源名稱",
                    "start": "開始時間",
                    "title": "任務標題",
                    "unitsHeader": "百分比"
                },
                "save": "保存",
                "views": {
                    "day": "日視圖",
                    "end": "任務結束",
                    "month": "月視圖",
                    "start": "任務開始",
                    "week": "周視圖",
                    "year": "年視圖"
                }
            });
    }

    /* GanttTimeline messages */
    if (kendo.ui.GanttTimeline) {
        kendo.ui.GanttTimeline.prototype.options.messages =
            $.extend(true, kendo.ui.GanttTimeline.prototype.options.messages,{
                "views": {
                    "day": "日視圖",
                    "week": "周視圖",
                    "month": "月視圖",
                    "year": "年視圖",
                    "start": "任務開始",
                    "end": "任務結束"
                }
            });
    }

    /* Grid messages */
    if (kendo.ui.Grid) {
        kendo.ui.Grid.prototype.options.messages =
            $.extend(true, kendo.ui.Grid.prototype.options.messages,{
                "commands": {
                    "cancel": "取消",
                    "canceledit": "取消",
                    "create": "新增",
                    "destroy": "刪除",
                    "edit": "編輯",
                    "excel": "匯出 Excel",
                    "pdf": "匯出 PDF",
                    "save": "保存",
                    "select": "選擇",
                    "update": "更新"
                },
                "editable": {
                    "cancelDelete": "取消刪除",
                    "confirmation": "你確定要刪除這條資料嗎？",
                    "confirmDelete": "確定刪除"
                },
                "noRecords": "無相關資料",
                "expandCollapseColumnHeader": ""
            });
    }

    /* Groupable messages */
    if (kendo.ui.Groupable) {
        kendo.ui.Groupable.prototype.options.messages =
            $.extend(true, kendo.ui.Groupable.prototype.options.messages,{
                "empty": "將欄位列名稱拖拽到此處可進行該列的分組顯示"
            });
    }

    /* NumericTextBox messages */
    if (kendo.ui.NumericTextBox) {
        kendo.ui.NumericTextBox.prototype.options =
            $.extend(true, kendo.ui.NumericTextBox.prototype.options,{
                "upArrowText": "增加",
                "downArrowText": "減少"
            });
    }

    /* MediaPlayer messages */
    if (kendo.ui.MediaPlayer) {
        kendo.ui.MediaPlayer.prototype.options.messages =
            $.extend(true, kendo.ui.MediaPlayer.prototype.options.messages,{
                "pause": "暫停",
                "play": "播放",
                "mute": "靜音",
                "unmute": "取消靜音",
                "quality": "畫質",
                "fullscreen": "全屏"
            });
    }

    /* Pager messages */
    if (kendo.ui.Pager) {
        kendo.ui.Pager.prototype.options.messages =
            $.extend(true, kendo.ui.Pager.prototype.options.messages,{
                "allPages": "全部",
                "display": "{0} - {1} 條　共 {2} 條數據",
                "empty": "無相關資料",
                "page": "轉到第",
                "of": "頁　共 {0} 頁",
                "itemsPerPage": "條每頁",
                "first": "首頁",
                "previous": "上一頁",
                "next": "下一頁",
                "last": "末頁",
                "refresh": "刷新",
                "morePages": "更多..."
            });
    }

    /* TreeListPager messages */
    if (kendo.ui.TreeListPager) {
        kendo.ui.TreeListPager.prototype.options.messages =
            $.extend(true, kendo.ui.TreeListPager.prototype.options.messages,{
                "allPages": "全部",
                "display": "{0} - {1} 條　共 {2} 條數據",
                "empty": "無相關資料",
                "page": "轉到第",
                "of": "頁　共 {0} 頁",
                "itemsPerPage": "條每頁",
                "first": "首頁",
                "previous": "上一頁",
                "next": "下一頁",
                "last": "末頁",
                "refresh": "刷新",
                "morePages": "更多..."
            });
    }

    /* PivotGrid messages */
    if (kendo.ui.PivotGrid) {
        kendo.ui.PivotGrid.prototype.options.messages =
            $.extend(true, kendo.ui.PivotGrid.prototype.options.messages,{
                "measureFields": "拖拽資料欄位到此處",
                "columnFields": "拖拽列欄位到此處",
                "rowFields": "拖拽行欄位到此處"
            });
    }

    /* PivotFieldMenu messages */
    if (kendo.ui.PivotFieldMenu) {
        kendo.ui.PivotFieldMenu.prototype.options.messages =
            $.extend(true, kendo.ui.PivotFieldMenu.prototype.options.messages,{
                "info": "篩選條件：",
                "sortAscending": "昇冪排列",
                "sortDescending": "降冪排列",
                "filterFields": "欄位篩選",
                "filter": "篩選",
                "include": "包含欄位...",
                "title": "包含的欄位",
                "clear": "清空",
                "ok": "確定",
                "cancel": "取消",
                "operators": {
                    "contains": "包含",
                    "doesnotcontain": "不含",
                    "startswith": "開頭是",
                    "endswith": "結尾是",
                    "eq": "等於",
                    "neq": "不等於"
                }
            });
    }

    /* PivotSettingTarget messages */
    if (kendo.ui.PivotSettingTarget) {
        kendo.ui.PivotSettingTarget.prototype.options.messages =
            $.extend(true, kendo.ui.PivotSettingTarget.prototype.options.messages,{
                "empty": "拖拽欄位到此處"
            });
    }

    /* PivotConfigurator messages */
    if (kendo.ui.PivotConfigurator) {
        kendo.ui.PivotConfigurator.prototype.options.messages =
            $.extend(true, kendo.ui.PivotConfigurator.prototype.options.messages,{
                "measures": "拖拽資料欄位到此處",
                "columns": "拖拽列欄位到此處",
                "rows": "拖拽行欄位到此處",
                "measuresLabel": "量",
                "columnsLabel": "列",
                "rowsLabel": "行",
                "fieldsLabel": "欄位"
            });
    }

    /* RecurrenceEditor messages */
    if (kendo.ui.RecurrenceEditor) {
        kendo.ui.RecurrenceEditor.prototype.options.messages =
            $.extend(true, kendo.ui.RecurrenceEditor.prototype.options.messages,{
                "recurrenceEditorTitle": "週期類型事件編輯",
                "frequencies": {
                    "never": "從不",
                    "hourly": "每小時",
                    "daily": "每天",
                    "weekly": "每週",
                    "monthly": "每月",
                    "yearly": "每年"
                },
                "hourly": {
                    "repeatEvery": "週期",
                    "interval": " 小時"
                },
                "daily": {
                    "repeatEvery": "週期",
                    "interval": " 天"
                },
                "weekly": {
                    "repeatEvery": "週期",
                    "repeatOn": "重複於",
                    "interval": " 周"
                },
                "monthly": {
                    "repeatEvery": "週期",
                    "repeatOn": "重複於",
                    "interval": " 月",
                    "day": "幾號 "
                },
                "yearly": {
                    "repeatEvery": "週期",
                    "repeatOn": "重複於",
                    "interval": " 年",
                    "of": " 在 "
                },
                "end": {
                    "label": "截止",
                    "mobileLabel": "截止",
                    "never": "從不",
                    "after": "重複 ",
                    "occurrence": " 次後",
                    "on": "止於 "
                },
                "offsetPositions": {
                    "first": "第一",
                    "second": "第二",
                    "third": "第三",
                    "fourth": "第四",
                    "last": "最後一"
                },
                "weekdays": {
                    "day": "天",
                    "weekday": "工作日",
                    "weekend": "週末"
                }
            });
    }

    /* MobileRecurrenceEditor messages */
    if (kendo.ui.MobileRecurrenceEditor) {
        kendo.ui.MobileRecurrenceEditor.prototype.options.messages =
            $.extend(true, kendo.ui.MobileRecurrenceEditor.prototype.options.messages,{
                "cancel": "取消",
                "update": "保存",
                "endTitle": "週期截止",
                "repeatTitle": "週期模式",
                "headerTitle": "週期事件",
                "end": {
                    "patterns": {
                        "never": "從不",
                        "after": "重複...",
                        "on": "止於..."
                    },
                    "never": "從不",
                    "after": "週期後截止",
                    "on": "週期時截止"
                },
                "daily": {
                    "interval": ""
                },
                "hourly": {
                    "interval": ""
                },
                "weekly": {
                    "interval": ""
                },
                "monthly": {
                    "interval": "",
                    "repeatBy": "重複到：",
                    "dayOfMonth": "幾號",
                    "dayOfWeek": "周幾",
                    "repeatEvery": "全部重複",
                    "every": "每",
                    "day": "天"
                },
                "yearly": {
                    "interval": "",
                    "repeatBy": "重複到：",
                    "dayOfMonth": "幾號",
                    "dayOfWeek": "周幾",
                    "repeatEvery": "全部重複",
                    "every": "每",
                    "month": "月",
                    "day": "天"
                }
            });
    }

    /* Scheduler messages */
    if (kendo.ui.Scheduler) {
        kendo.ui.Scheduler.prototype.options.messages =
            $.extend(true, kendo.ui.Scheduler.prototype.options.messages,{
                "allDay": "全天",
                "date": "日期",
                "event": "事件",
                "time": "時間",
                "showFullDay": "顯示全天",
                "showWorkDay": "顯示工作時間",
                "today": "今天",
                "pdf": "匯出 PDF",
                "save": "保存",
                "cancel": "取消",
                "destroy": "刪除",
                "deleteWindowTitle": "刪除事件",
                "next": "往後",
                "previous": "往前",
                "ariaSlotLabel": "從 {0:t} 到 {1:t} 的選擇",
                "ariaEventLabel": "在 {1:D} {2:t} 的 {0}",
                "editable": {
                    "confirmation": "你確定要刪除這個事件嗎？"
                },
                "views": {
                    "day": "日視圖",
                    "week": "周視圖",
                    "workWeek": "工作日視圖",
                    "agenda": "列表視圖",
                    "month": "月視圖",
                    "timeline": "時間線",
                    "timelineWeek": "時間線周視圖",
                    "timelineWorkWeek": "時間線工作日視圖",
                    "timelineMonth": "時間線月視圖"
                },
                "recurrenceMessages": {
                    "deleteWindowTitle": "刪除週期類型事件",
                    "deleteWindowOccurrence": "刪除當前事件",
                    "deleteWindowSeries": "刪除整個週期事件",
                    "editWindowTitle": "編輯週期類型事件",
                    "editWindowOccurrence": "編輯當前事件",
                    "editWindowSeries": "編輯整個週期事件",
                    "deleteRecurring": "你想僅刪除當前事件還是整個週期事件？",
                    "editRecurring": "你想僅編輯當前事件還是整個週期事件？"
                },
                "editor": {
                    "title": "事件標題",
                    "start": "開始時間",
                    "end": "結束時間",
                    "allDayEvent": "全天事件",
                    "description": "描述",
                    "repeat": "重複",
                    "timezone": "時區",
                    "startTimezone": "開始時區",
                    "endTimezone": "結束時區",
                    "separateTimezones": "使用獨立的開始和結束時區",
                    "timezoneEditorTitle": "時區設置",
                    "timezoneEditorButton": "時區選擇",
                    "timezoneTitle": "選擇時區",
                    "noTimezone": "無時區",
                    "editorTitle": "事件"
                }
            });
    }

    /* Spreadsheet messages */
    if (kendo.spreadsheet && kendo.spreadsheet.messages.borderPalette) {
        kendo.spreadsheet.messages.borderPalette =
            $.extend(true, kendo.spreadsheet.messages.borderPalette,{
                "allBorders": "內外框線",
                "insideBorders": "內框線",
                "insideHorizontalBorders": "橫向內框線",
                "insideVerticalBorders": "縱向內框線",
                "outsideBorders": "外框線",
                "leftBorder": "左框線",
                "topBorder": "上框線",
                "rightBorder": "右框線",
                "bottomBorder": "下框線",
                "noBorders": "無框線",
                "reset": "無填充顏色",
                "customColor": "其他顏色...",
                "apply": "確定",
                "cancel": "取消"
            });
    }

    if (kendo.spreadsheet && kendo.spreadsheet.messages.dialogs) {
        kendo.spreadsheet.messages.dialogs =
            $.extend(true, kendo.spreadsheet.messages.dialogs,{
                "apply": "確定",
                "save": "保存",
                "cancel": "取消",
                "remove": "移除",
                "retry": "重試",
                "revert": "復原",
                "okText": "確定",
                "formatCellsDialog": {
                    "title": "單元格格式",
                    "categories": {
                        "number": "數字",
                        "currency": "貨幣",
                        "date": "日期"
                    }
                },
                "fontFamilyDialog": {
                    "title": "字體"
                },
                "fontSizeDialog": {
                    "title": "字型大小"
                },
                "bordersDialog": {
                    "title": "邊框"
                },
                "alignmentDialog": {
                    "title": "對齊",
                    "buttons": {
                        "justtifyLeft": "左對齊",
                        "justifyCenter": "水準居中",
                        "justifyRight": "右對齊",
                        "justifyFull": "兩端對齊",
                        "alignTop": "頂端對齊",
                        "alignMiddle": "垂直居中",
                        "alignBottom": "底端對齊"
                    }
                },
                "mergeDialog": {
                    "title": "合併儲存格",
                    "buttons": {
                        "mergeCells": "全部合併",
                        "mergeHorizontally": "水準合併",
                        "mergeVertically": "垂直合併",
                        "unmerge": "取消合併"
                    }
                },
                "freezeDialog": {
                    "title": "凍結窗格",
                    "buttons": {
                        "freezePanes": "凍結上行左列",
                        "freezeRows": "凍結上部行",
                        "freezeColumns": "凍結左側列",
                        "unfreeze": "取消凍結"
                    }
                },
                "confirmationDialog": {
                    "text": "你確定要刪除這張工作表嗎？",
                    "title": "刪除工作表"
                },
                "validationDialog": {
                    "title": "資料驗證",
                    "hintMessage": "請輸入一個{1}的{0}值",
                    "hintTitle": "驗證{0}",
                    "criteria": {
                        "any": "任何值",
                        "number": "數字",
                        "text": "文本",
                        "date": "日期",
                        "custom": "自訂公式",
                        "list": "序列"
                    },
                    "comparers": {
                        "greaterThan": "大於",
                        "lessThan": "小於",
                        "between": "介於",
                        "notBetween": "不介於",
                        "equalTo": "等於",
                        "notEqualTo": "不等於",
                        "greaterThanOrEqualTo": "大於等於",
                        "lessThanOrEqualTo": "小於等於"
                    },
                    "comparerMessages": {
                        "greaterThan": "大於{0}",
                        "lessThan": "小於{0}",
                        "between": "介於{0}和{1}之間",
                        "notBetween": "不介於{0}和{1}之間",
                        "equalTo": "等於{0}",
                        "notEqualTo": "不等於{0}",
                        "greaterThanOrEqualTo": "大於等於{0}",
                        "lessThanOrEqualTo": "小於等於{0}",
                        "custom": "滿足公式{0}"
                    },
                    "labels": {
                        "criteria": "允許",
                        "comparer": "比較",
                        "min": "最小值",
                        "max": "最大值",
                        "value": "值",
                        "start": "開始",
                        "end": "結束",
                        "onInvalidData": "對無效的數據",
                        "rejectInput": "拒絕輸入",
                        "showWarning": "顯示警告",
                        "showHint": "選定儲存格時顯示",
                        "hintTitle": "選定時的標題",
                        "hintMessage": "選定時的信息",
                        "ignoreBlank": "忽略空值",
                        "showListButton": "顯示序列按鈕",
                        "showCalendarButton": "顯示日曆按鈕"
                    },
                    "placeholders": {
                        "typeTitle": "請輸入標題",
                        "typeMessage": "請輸入資訊"
                    }
                },
                "exportAsDialog": {
                    "title": "匯出...",
                    "labels": {
                        "scale": "縮放",
                        "fit": "調整為一頁",
                        "fileName": "檔案名",
                        "saveAsType": "保存類型",
                        "exportArea": "匯出範圍",
                        "paperSize": "紙張大小",
                        "margins": "頁邊距",
                        "orientation": "紙張方向",
                        "print": "列印",
                        "guidelines": "格線",
                        "center": "居中方式",
                        "horizontally": "水準",
                        "vertically": "垂直"
                    }
                },
                "modifyMergedDialog": {
                    "errorMessage": "不能更改已合併儲存格的局部。"
                },
                "rangeDisabledDialog": {
                    "errorMessage": "指定範圍包含禁用儲存格。"
                },
                "incompatibleRangesDialog": {
                    "errorMessage": "範圍不匹配"
                },
                "noFillDirectionDialog": {
                    "errorMessage": "無法判斷填充方向"
                },
                "duplicateSheetNameDialog": {
                    "errorMessage": "工作表名稱重複"
                },
                "overflowDialog": {
                    "errorMessage": "不能粘貼，因為複製區域和粘貼區域的大小和形狀不一樣。"
                },
                "useKeyboardDialog": {
                    "title": "複製和粘貼",
                    "errorMessage": "不能通過功能表調用這些操作，請使用鍵盤快速鍵代替：",
                    "labels": {
                        "forCopy": "為複製",
                        "forCut": "為剪切",
                        "forPaste": "為粘貼"
                    }
                },
                "unsupportedSelectionDialog": {
                    "errorMessage": "不能在多選的情況下執行該操作。"
                },
                "linkDialog": {
                    "title": "連結",
                    "labels": {
                        "text": "連結文字",
                        "url": "連結位址",
                        "removeLink": "移除連結"
                    }
                }
            });
    }

    if (kendo.spreadsheet && kendo.spreadsheet.messages.filterMenu) {
        kendo.spreadsheet.messages.filterMenu =
            $.extend(true, kendo.spreadsheet.messages.filterMenu,{
                "sortAscending": "按A到Z昇冪排列",
                "sortDescending": "按Z到A降冪排列",
                "filterByValue": "內容篩選",
                "filterByCondition": "條件篩選",
                "apply": "確定",
                "search": "搜索",
                "addToCurrent": "添加到當前選擇",
                "clear": "清空",
                "blanks": "（無）",
                "operatorNone": "無",
                "and": "並且",
                "or": "或者",
                "operators": {
                    "string": {
                        "contains": "文本包含",
                        "doesnotcontain": "文本不包含",
                        "startswith": "文本開頭是",
                        "endswith": "文本結尾是",
                        "matches": "文本等於",
                        "doesnotmatch": "文本不等於"
                    },
                    "date": {
                        "eq":  "日期等於",
                        "neq": "日期不等於",
                        "lt":  "日期早於",
                        "gt":  "日期晚於"
                    },
                    "number": {
                        "eq": "數字等於",
                        "neq": "數字不等於",
                        "gte": "數字大於等於",
                        "gt": "數字大於",
                        "lte": "數字小於等於",
                        "lt": "數字小於"
                    }
                }
            });
    }

    if (kendo.spreadsheet && kendo.spreadsheet.messages.colorPicker) {
        kendo.spreadsheet.messages.colorPicker =
            $.extend(true, kendo.spreadsheet.messages.colorPicker,{
                "reset": "無填充顏色",
                "customColor": "其他顏色...",
                "apply": "確定",
                "cancel": "取消"
            });
    }

    if (kendo.spreadsheet && kendo.spreadsheet.messages.toolbar) {
        kendo.spreadsheet.messages.toolbar =
            $.extend(true, kendo.spreadsheet.messages.toolbar,{
                "addColumnLeft": "在左側插入列",
                "addColumnRight": "在右側插入列",
                "addRowAbove": "在上面插入行",
                "addRowBelow": "在下麵插入行",
                "alignment": "對齊",
                "alignmentButtons": {
                    "justtifyLeft": "左對齊",
                    "justifyCenter": "水準居中",
                    "justifyRight": "右對齊",
                    "justifyFull": "兩端對齊",
                    "alignTop": "頂端對齊",
                    "alignMiddle": "垂直居中",
                    "alignBottom": "底端對齊"
                },
                "backgroundColor": "背景顏色",
                "bold": "粗體",
                "borders": "邊框",
                "colorPicker": {
                    "reset": "無填充顏色",
                    "customColor": "其他顏色..."
                },
                "copy": "複製",
                "cut": "剪切",
                "deleteColumn": "刪除整列",
                "deleteRow": "刪除整行",
                "excelImport": "從 Excel 導入...",
                "exportAs": "匯出為...",
                "filter": "篩選",
                "fontFamily": "字體",
                "fontSize": "字型大小",
                "format": "定制格式...",
                "formatTypes": {
                    "automatic": "自動",
                    "text": "文本",
                    "number": "數字",
                    "percent": "百分比",
                    "financial": "財務",
                    "currency": "貨幣",
                    "date": "日期",
                    "time": "時間",
                    "dateTime": "日期時間",
                    "duration": "時分秒",
                    "moreFormats": "更多格式..."
                },
                "formatDecreaseDecimal": "減少小數位數",
                "formatIncreaseDecimal": "增加小數位數",
                "freeze": "凍結窗格",
                "freezeButtons": {
                    "freezePanes": "凍結上行左列",
                    "freezeRows": "凍結上部行",
                    "freezeColumns": "凍結左側列",
                    "unfreeze": "取消凍結"
                },
                "italic": "斜體",
                "merge": "合併儲存格",
                "mergeButtons": {
                    "mergeCells": "全部合併",
                    "mergeHorizontally": "水準合併",
                    "mergeVertically": "垂直合併",
                    "unmerge": "取消合併"
                },
                "open": "打開...",
                "paste": "粘貼",
                "quickAccess": {
                    "redo": "重做",
                    "undo": "撤銷"
                },
                "toggleGridlines": "切換格線",
                "saveAs": "另存為...",
                "sort": "排序",
                "sortAsc": "昇冪排列",
                "sortDesc": "降冪排列",
                "sortButtons": {
                    "sortSheetAsc": "表格按A到Z昇冪排列",
                    "sortSheetDesc": "表格按Z到A降冪排列",
                    "sortRangeAsc": "選定範圍按A到Z昇冪排列",
                    "sortRangeDesc": "選定範圍按Z到A降冪排列"
                },
                "textColor": "文字顏色",
                "textWrap": "文字換行",
                "underline": "底線",
                "validation": "資料驗證...",
                "hyperlink": "連結"
            });
    }

    if (kendo.spreadsheet && kendo.spreadsheet.messages.view) {
        kendo.spreadsheet.messages.view =
            $.extend(true, kendo.spreadsheet.messages.view,{
                "errors": {
                    "openUnsupported": "不支持的格式，請選擇一個尾碼名為 .xlsx 的文件。",
                    "shiftingNonblankCells": "由於資料可能丟失無法插入儲存格，請選擇另一處插入或者從工作表的尾部刪除資料。",
                    "insertColumnWhenRowIsSelected": "在選擇所有列時不能插入列。",
                    "insertRowWhenColumnIsSelected": "在選擇所有行時不能插入行。",
                    "filterRangeContainingMerges": "無法在包含合併儲存格的情況下進行篩選",
                    "sortRangeContainingMerges": "無法在包含合併儲存格的情況下排序",
                    "cantSortMultipleSelection": "無法在多選的情況下排序",
                    "cantSortNullRef": "無法在沒有選擇的情況下排序",
                    "cantSortMixedCells": "無法在包含有混合形狀儲存格的情況下排序",
                    "validationError": "你輸入的值不符合目前的儲存格的驗證規則。",
                    "cannotModifyDisabled": "不能修改被禁用的儲存格。"
                },
                "tabs": {
                    "home": "開始",
                    "insert": "插入",
                    "data": "數據"
                }
            });
    }

    /* Slider messages */
    if (kendo.ui.Slider) {
        kendo.ui.Slider.prototype.options =
            $.extend(true, kendo.ui.Slider.prototype.options,{
                "increaseButtonTitle": "增加",
                "decreaseButtonTitle": "減少",
                "dragHandleTitle": "拖"
            });
    }

    /* ListBox messages */
    if (kendo.ui.ListBox) {
        kendo.ui.ListBox.prototype.options.messages =
            $.extend(true, kendo.ui.ListBox.prototype.options.messages,{
                "tools": {
                    "remove": "刪除",
                    "moveUp": "上移",
                    "moveDown": "下移",
                    "transferTo": "轉移過去",
                    "transferFrom": "轉移回來",
                    "transferAllTo": "全部轉移過去",
                    "transferAllFrom": "全部轉移回來"
                }
            });
    }

    /* TreeList messages */
    if (kendo.ui.TreeList) {
        kendo.ui.TreeList.prototype.options.messages =
            $.extend(true, kendo.ui.TreeList.prototype.options.messages,{
                "noRows": "無相關資料",
                "loading": "載入中...",
                "requestFailed": "請求失敗！",
                "retry": "重試",
                "commands": {
                    "edit": "編輯",
                    "update": "更新",
                    "canceledit": "取消",
                    "create": "新增",
                    "createchild": "新增子項",
                    "destroy": "刪除",
                    "excel": "匯出 Excel",
                    "pdf": "匯出 PDF"
                }
            });
    }

    /* TreeView messages */
    if (kendo.ui.TreeView) {
        kendo.ui.TreeView.prototype.options.messages =
            $.extend(true, kendo.ui.TreeView.prototype.options.messages,{
                "loading": "載入中...",
                "requestFailed": "請求失敗！",
                "retry": "重試"
            });
    }

    /* PanelBar messages */
    if (kendo.ui.PanelBar) {
        kendo.ui.PanelBar.prototype.options.messages =
            $.extend(true, kendo.ui.PanelBar.prototype.options.messages,{
                "loading": "載入中...",
                "requestFailed": "請求失敗！",
                "retry": "重試"
            });
    }

    /* Upload messages */
    if (kendo.ui.Upload) {
        kendo.ui.Upload.prototype.options.localization=
            $.extend(true, kendo.ui.Upload.prototype.options.localization,{
                "select": "選擇檔",
                "cancel": "取消",
                "retry": "重試",
                "remove": "移除",
                "pause": "暫停",
                "resume": "恢復",
                "clearSelectedFiles": "清空",
                "uploadSelectedFiles": "上傳",
                "dropFilesHere": "將文件拖拽到此處上傳",
                "invalidFiles": "檔不符合要求！",
                "statusUploading": "上傳中...",
                "statusUploaded": "上傳成功！",
                "statusWarning": "上傳警告！",
                "statusFailed": "上傳失敗！",
                "headerStatusUploading": "上傳中...",
                "headerStatusPaused": "上傳暫停",
                "headerStatusUploaded": "上傳完成！",
                "invalidMaxFileSize": "文件太大！",
                "invalidMinFileSize": "文件太小！",
                "invalidFileExtension": "不支持的檔案格式！"
            });
    }

    /* Validator messages */
    if (kendo.ui.Validator) {
        kendo.ui.Validator.prototype.options.messages =
            $.extend(true, kendo.ui.Validator.prototype.options.messages,{
                "required": "{0} 是必填項！",
                "pattern": "{0} 的格式不正確！",
                "min": "{0} 必須大於或等於 {1} ！",
                "max": "{0} 必須小於或等於 {1} ！",
                "step": "{0} 不是正確的步進值！",
                "email": "{0} 不是正確的電子郵件格式！",
                "url": "{0} 不是正確的網址格式！",
                "date": "{0} 不是正確的日期格式！",
                "dateCompare": "結束日期必須晚於或等於開始日期！"
            });
    }

    /* Progress messages */
    if (kendo.ui.progress) {
        kendo.ui.progress.messages =
            $.extend(true, kendo.ui.progress.messages, {
                "loading": "載入中..."
            });
    }

    /* Dialog messages */
    if (kendo.ui.Dialog) {
        kendo.ui.Dialog.prototype.options.messages =
            $.extend(true, kendo.ui.Dialog.prototype.options.localization, {
                "close": "關閉"
            });
    }

    /* Calendar messages */
    if (kendo.ui.Calendar) {
        kendo.ui.Calendar.prototype.options.messages =
            $.extend(true, kendo.ui.Calendar.prototype.options.messages, {
                "weekColumnHeader": ""
            });
    }

    /* Alert messages */
    if (kendo.ui.Alert) {
        kendo.ui.Alert.prototype.options.messages =
            $.extend(true, kendo.ui.Alert.prototype.options.localization, {
                "okText": "確定"
            });
    }

    /* Confirm messages */
    if (kendo.ui.Confirm) {
        kendo.ui.Confirm.prototype.options.messages =
            $.extend(true, kendo.ui.Confirm.prototype.options.localization, {
                "okText": "確定",
                "cancel": "取消"
            });
    }

    /* Prompt messages */
    if (kendo.ui.Prompt) {
        kendo.ui.Prompt.prototype.options.messages =
            $.extend(true, kendo.ui.Prompt.prototype.options.localization, {
                "okText": "確定",
                "cancel": "取消"
            });
    }

    /* DateInput messages */
    if (kendo.ui.DateInput) {
        kendo.ui.DateInput.prototype.options.messages =
            $.extend(true, kendo.ui.DateInput.prototype.options.messages, {
                "year": "年",
                "month": "月",
                "day": "日",
                "weekday": "周",
                "hour": "時",
                "minute": "分",
                "second": "秒",
                "dayperiod": "上午/下午"
            });
    }

    /* DropDownTree messages */
    if (kendo.ui.DropDownTree) {
        kendo.ui.DropDownTree.prototype.options.messages =
            $.extend(true, kendo.ui.DropDownTree.prototype.options.messages, {
                clear: "清空",
                deleteTag: "刪除",
                singleTag: "項已選擇"
            });
    }

    /* Chat messages */
    if (kendo.ui.Chat) {
        kendo.ui.Chat.prototype.options.messages =
            $.extend(true, kendo.ui.Chat.prototype.options.messages, {
                placeholder: "請輸入..."
            });
    }

    /* Mobile Messages ------------------------------ */

    /* Mobile Scroller messages */
    if (kendo.mobile.ui.Scroller) {
        kendo.mobile.ui.Scroller.prototype.options.messages =
            $.extend(true, kendo.mobile.ui.Scroller.prototype.options.messages, {
                "pullTemplate": "下拉刷新",
                "releaseTemplate": "釋放刷新",
                "refreshTemplate": "刷新中..."
            });
    }

    /* Mobile ListView messages */
    if (kendo.mobile.ui.ListView) {
        kendo.mobile.ui.ListView.prototype.options.messages =
            $.extend(true, kendo.mobile.ui.ListView.prototype.options.messages, {
                "loadMoreText": "點擊載入更多",
                "pullTemplate": "下拉刷新",
                "releaseTemplate": "釋放刷新",
                "refreshTemplate": "刷新中..."
            });
    }

})(window.kendo.jQuery);
}));