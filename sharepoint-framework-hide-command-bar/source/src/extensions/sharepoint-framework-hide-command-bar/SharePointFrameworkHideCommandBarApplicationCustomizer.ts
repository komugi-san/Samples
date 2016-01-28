import { override } from '@microsoft/decorators';
import { Log } from '@microsoft/sp-core-library';
import {
    BaseApplicationCustomizer
} from '@microsoft/sp-application-base';
import { Dialog } from '@microsoft/sp-dialog';

import * as strings from 'SharePointFrameworkHideCommandBarApplicationCustomizerStrings';

const LOG_SOURCE: string = 'SharePointFrameworkHideCommandBarApplicationCustomizer';

/**
 * If your command set uses the ClientSideComponentProperties JSON input,
 * it will be deserialized into the BaseExtension.properties object.
 * You can define an interface to describe it.
 */
export interface ISharePointFrameworkHideCommandBarApplicationCustomizerProperties {
}

/** A Custom Action which can be run during execution of a Client Side Application */
export default class SharePointFrameworkHideCommandBarApplicationCustomizer
    extends BaseApplicationCustomizer<ISharePointFrameworkHideCommandBarApplicationCustomizerProperties> {

    @override
    public onInit(): Promise<void> {
        window.addEventListener("load", e => {
            var elements = document.querySelectorAll('span.CommandBarItem-commandText');
            console.log(elements.length);
            for (var i = 0; i < elements.length; i++) {
                var element = elements[i];
                if (element.textContent === '新規') {
                    var parent = element.closest('.CommandBarItem') as HTMLElement;
                    parent.style.display = 'none';
                }
            }
        });
        return Promise.resolve();
    }

}
