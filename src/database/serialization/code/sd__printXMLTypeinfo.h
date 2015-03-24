/*
 *                         OpenSplice DDS
 *
 *   This software and documentation are Copyright 2006 to TO_YEAR PrismTech
 *   Limited, its affiliated companies and licensors. All rights reserved.
 *
 *   Licensed under the Apache License, Version 2.0 (the "License");
 *   you may not use this file except in compliance with the License.
 *   You may obtain a copy of the License at
 *
 *       http://www.apache.org/licenses/LICENSE-2.0
 *
 *   Unless required by applicable law or agreed to in writing, software
 *   distributed under the License is distributed on an "AS IS" BASIS,
 *   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *   See the License for the specific language governing permissions and
 *   limitations under the License.
 *
 */
#ifndef SD__PRINTXMLTYPEINFO_H
#define SD__PRINTXMLTYPEINFO_H

#include "sd__contextItem.h"

#define SPLICE_METADATA_TAG  "MetaData"

c_long
sd_printXmlTypeinfoLength (
    sd_contextItem item,
    c_bool escapeQuote);

void
sd_printXmlTypeinfo (
    sd_contextItem item,
    char *buffer,
    c_bool escapeQuote
    );

#endif /* SD__PRINTXMLTYPEINFO_H */