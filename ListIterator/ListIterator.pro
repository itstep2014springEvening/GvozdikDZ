TEMPLATE = app
CONFIG += console
CONFIG -= app_bundle
CONFIG -= qt

SOURCES += main.cpp \
    list.cpp \
    iterator.cpp

include(deployment.pri)
qtcAddDeployment()

HEADERS += \
    list.h \
    iterator.h

