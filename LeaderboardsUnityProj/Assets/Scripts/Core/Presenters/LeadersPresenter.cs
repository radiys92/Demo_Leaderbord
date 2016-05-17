using System.Collections;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class LeadersPresenter : LeaderboardPanelPresenter
{
    public Button InviteButton;

    public LayoutGroup GridGroup;

    void Start()
    {
        UpdateCellsData();
        ParentScreen.OnLeadersDataUpdate.AddListener(UpdateCellsData);
    }

    private void UpdateCellsData()
    {
        var grid = GridGroup.transform;

        // clean cells 
        var childs = grid.Cast<Transform>().ToArray();
        for (var i = 1; i < childs.Length; i++)
        {
            Destroy(childs[i].gameObject);
        }
        var prefab = childs[0];

        // add new 
        var data = ParentScreen.GetTop10ViewData();
        foreach (var viewData in data)
        {
            CreateCell(prefab, viewData);
        }

        Destroy(prefab.gameObject);
    }

    private void CreateCell(Transform prefab, UserTopViewData viewData)
    {
        var go = Instantiate(prefab);
        go.SetParent(GridGroup.transform, false);
        var presenter = go.GetComponent<LeaderCellPresenter>();
        presenter.SetData(viewData);
    }
}