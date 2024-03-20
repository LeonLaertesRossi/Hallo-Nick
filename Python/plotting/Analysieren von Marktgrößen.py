import matplotlib.pyplot as plt
import numpy as np

fig, ax = plt.subplots(2, 2, figsize=(8, 8))

size = [[0.12, 0.88],[0.15, 0.85],[0.25, 0.75],[0.10, 0.90]]
v = np.array([[100, 0, 0], [9.83, 16.33, 73.44], [13.54, 11.64, 74.82], [10.34, 6.52, 83.14], [3.14, 29.8, 67.6]])
pr = ["9.83%", "16.33%", "73.44%"]
pr1=["13.54%", "11.64%", "74.82%"]
pr2= [["10.34%", "6.52%", "83.14%",], ["3.14%", "29.8%", "67.6%"],[]]
mp = [pr, pr1, pr2]
cmap = plt.colormaps["tab20c"]
outer_colors = cmap(np.arange(3) * 4)
inner_colors = cmap([1, 2, 3, 4, 5, 6, 7, 8, 9])
label1 = ["Marktpotenzial"]
label2 = ["Careli", "stärkster Wettbewerber", "restliche Anbieter"]
legends = []
ll = ["Marktsegment Businesstaschen", "Marktsegment Reisetaschen", "Marktsegment Handtaschen", "Marktsegment Rucksäcke"]
w = 0

for i in range(2):
    for j in range(2):
        ax[i, j].pie([v[0, 0]], radius=1, wedgeprops=dict(width=size[i * 2 + j][0], edgecolor="w"), colors=outer_colors)
        ax[i, j].pie(v[i * 2 + j + 1], radius=1 - size[i * 2 + j][0], wedgeprops=dict(width=size[i * 2 + j][1], edgecolor="w"), colors=inner_colors)
        ax[i, j].set(aspect="equal", title=ll[w])
        w += 1
        for p in ax[i, j].patches:
            p.set_label("")

        handles = []
        handles.append(plt.Line2D([0], [0], marker='o', color=outer_colors[0], label=label1[0], markersize=10))
        for k, l in enumerate(label2):
            handles.append(plt.Line2D([0], [0], marker='o', color=inner_colors[k], label=l, markersize=10))

        legend = ax[i, j].legend(handles=handles, title="Marktgrößen", loc="upper left", bbox_to_anchor=(1, 1))
        legends.append(legend)

w1 = 0
w2 = 0
w = 0
jjj = [""]

for i in range(2):
    for j in range(2):
        ax[i, j].pie([v[0, 0]], radius=1, wedgeprops=dict(width=size[i * 2 + j][0], edgecolor="w"), colors=outer_colors, labels=jjj)
        ax[i, j].pie(v[i * 2 + j + 1], radius=1 - size[i * 2 + j][0], wedgeprops=dict(width=size[i * 2 + j][1], edgecolor="w"), colors=inner_colors, labels = mp[w1], labeldistance= 0.55)
        ax[i, j].set(aspect="equal", title=ll[w])
        if w2 == 1:
            w1 = -1
            mp = mp[2]
        w += 1
        w1+=1
        w2 += 1

plt.show()
